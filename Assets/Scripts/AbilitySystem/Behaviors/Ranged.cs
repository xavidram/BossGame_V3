using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ranged : AbilityBehavior
{

    private const string aName = "Ranged";
    private const string aDesc = "Ranged Attack Class";
    //private const Sprite icon = Resources.Load(); //set path when get sprite
    private const BehaviorStartTime startTime = BehaviorStartTime.Beginning;

    //Ranged Attack Distances
    private float minDistance;
    private float maxDistance;
    private bool isRandomOn;
    private float lifeDistance; //Maximum distance before object is destroyed and disapears from scene
    private float projectileSpeed = 2f;

    public Ranged(float minDist, float maxDist,float pSpeed, bool isRandom) : base(new BasicObjectInformation(aName, aDesc), startTime)
    {
        maxDistance = maxDist;
        minDistance = minDist;
        projectileSpeed = pSpeed;
        isRandomOn = isRandom;
        // Do we want random distance or a fixed distance before object is deleted.
    }

    public override void PerformBehavior(GameObject Player, GameObject abilityPrefab)
    {
        lifeDistance = isRandomOn ? Random.Range(minDistance, maxDistance) : maxDistance;
        Debug.Log("distance: " + lifeDistance);

        //Ignore Colision with player
        Physics2D.IgnoreCollision(Player.GetComponent<Collider2D>(), abilityPrefab.GetComponent<Collider2D>(),true);

        Job.make(CheckDistance(Player.transform.position, abilityPrefab), true);
        //StartCoroutine(CheckDistance(Player.transform.position));
    }

    // Co-Routine to check distance
    private IEnumerator CheckDistance(Vector3 startPosition, GameObject abilityPrefab)
    {
        // Enable prefab
        if (!abilityPrefab.activeSelf)
        {
            abilityPrefab.SetActive(true);
        }

        Vector3 mouseLocation = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseLocation.z = 0.0f; //no z axis
        float tDistance = Vector3.Distance(startPosition, abilityPrefab.transform.position);
        while (tDistance < lifeDistance)
        {
            //check to see if object that is ranged has reached the point
            // Dont delete, lets set up a game pool.
            tDistance = Vector3.Distance(startPosition, abilityPrefab.transform.position);
            abilityPrefab.transform.Translate(mouseLocation * projectileSpeed * Time.deltaTime);
            yield return null;
        }
        //this.gameObject.SetActive(false); for pooling
        GameObject.Destroy(abilityPrefab);
        yield return null;
    }

    //Getters
    public float MinDistance
    {
        get { return minDistance; }
    }

    public float MaxDistance
    {
        get { return maxDistance; }
    }
    public float ProjectileSpeed
    {
        get { return projectileSpeed; }
    }
}

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

    public Ranged(float minDist, float maxDist, bool isRandom) : base(new BasicObjectInformation(aName, aDesc), startTime)
    {
        maxDistance = maxDist;
        minDistance = minDist;
        isRandomOn = isRandom;
        // Do we want random distance or a fixed distance before object is deleted.
    }

    public override void PerformBehavior(GameObject Player, GameObject obj)
    {
        lifeDistance = isRandomOn ? Random.Range(minDistance, maxDistance) : maxDistance;
        StartCoroutine(CheckDistance(Player.transform.position));
    }

    // Co-Routine to check distance
    private IEnumerator CheckDistance(Vector3 startPosition)
    {
        float tDistance = Vector3.Distance(startPosition, this.transform.position);
        while (tDistance < lifeDistance)
        {
            //check to see if object that is ranged has reached the point
            // Dont delete, lets set up a game pool.
            tDistance = Vector3.Distance(startPosition, this.transform.position);

        }
        this.gameObject.SetActive(false);
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
}

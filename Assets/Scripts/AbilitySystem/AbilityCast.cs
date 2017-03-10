using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class AbilityCast : MonoBehaviour {

    public GameObject fireBall;
    private FireBall fireballAbility;
    private Stopwatch abilityCooldownTimer;
    
    public void OnAbilityCast()
    {
        UnityEngine.Debug.Log("Ability Casted");
        abilityCooldownTimer = new Stopwatch();
        abilityCooldownTimer.Start();
        fireballAbility = new FireBall();

        GameObject cast = Instantiate<GameObject>(fireBall);
        cast.transform.position = this.transform.position;
        fireballAbility.AbilityPrefab = cast;
        fireballAbility.UseAbility(this.gameObject);


        StartCoroutine(CoolDown());
    }

    private IEnumerator CoolDown()
    {
        UnityEngine.Debug.Log(fireballAbility.CoolDownTime);
        while(abilityCooldownTimer.IsRunning && abilityCooldownTimer.Elapsed.TotalSeconds < fireballAbility.CoolDownTime)
        {
            yield return null;
        }
        //Prevent user from casting again when pressing command
        abilityCooldownTimer.Stop();
        abilityCooldownTimer.Reset();
        yield return null;
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            OnAbilityCast();
        }
	}
}

﻿using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public class AreaOfEffect : AbilityBehavior{

    private const string aName = "Area of Effect";
    private const string aDesc = "Damage dealt to any entity within object area";
    //private const Sprite icon = Resources.Load(); //set path when get sprite
    private const BehaviorStartTime startTime = BehaviorStartTime.End;

    //AOE
    private float areaRadius;   //radius of sphere collider
    private float effectDuration;   //how long effect lasts
    private Stopwatch durationTimer = new Stopwatch();  //timmer to keep track of AOE duration
    private float baseDamage;   //Damage done by the AOE
    private bool isOccupied;
    private float damageTickDuration;

    public AreaOfEffect(float radius, float Duration, float Damage) : base(new BasicObjectInformation(aName, aDesc), startTime)
    {
        areaRadius = radius;
        effectDuration = Duration;
        baseDamage = Damage;
        isOccupied = false;
    }

    public override void PerformBehavior(GameObject Player, GameObject abilityPrefab)
    {
        /*
        CircleCollider2D colider = this.gameObject.GetComponent<CircleCollider2D>();
        colider.radius = areaRadius;
        colider.isTrigger = true;

        StartCoroutine(AOE());
        */
    }

    private IEnumerator AOE()
    {
        durationTimer.Start();  //  Start the timer
        while (durationTimer.Elapsed.TotalSeconds <= effectDuration)    // Check if time elpased < duration of AOE
        {
            if (isOccupied)
            {
                //do Damage
                //onDamage(list<targets>, baseDamage);
            }
            yield return new WaitForSeconds(damageTickDuration);
        }
        //Stop and reset timer for next run.
        durationTimer.Stop();
        durationTimer.Reset();
        yield return null;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isOccupied)
        {
            // do damage
        }else
        {
            isOccupied = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isOccupied = false;
    }

}

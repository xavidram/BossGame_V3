using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Slow : AbilityBehavior {

    private const string aName = "Slow";
    private const string aDesc = "Slows object speed";
    //private const Sprite icon = Resources.Load(); //set path when get sprite
    private const BehaviorStartTime startTime = BehaviorStartTime.End;

    //SLOW
    private float effectDuration;   //how long effect lasts
    private float speedReduction;   //should do percent or base value?


    public Slow(float Duration, float slow) : base(new BasicObjectInformation(aName, aDesc), startTime)
    {
        effectDuration = Duration;
        speedReduction = slow;
    }

    public override void PerformBehavior(GameObject Player, GameObject obj)
    {
        //StartCoroutine(SlowMovement(obj));
    }

    private IEnumerator SlowMovement(GameObject obj)
    {
        /*
         Find object, get movement variable, change value by subtracting base speedReduction
        */
        //if(obj.GetComponent<"Speed">() != null)
        yield return new WaitForSeconds(effectDuration);
        // Reset movment speed after effect has expired
        yield return null;
    }
}

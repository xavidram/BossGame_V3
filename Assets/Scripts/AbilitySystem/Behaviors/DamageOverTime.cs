using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class DamageOverTime : AbilityBehavior {

    private const string aName = "Damage Over Time";
    private const string aDesc = "Damage dealt to entity over a period of time";
    //private const Sprite icon = Resources.Load(); //set path when get sprite
    private const BehaviorStartTime startTime = BehaviorStartTime.Beginning;

    //DOT
    private float effectDuration;   //how long effect lasts
    private Stopwatch durationTimer = new Stopwatch();  //timmer to keep track of DOT duration
    private float baseDamage;   //Damage done by the DOT
    private float damageTickDuration;


    public DamageOverTime(float Duration, float Damage, float DamageTickDuration) : base(new BasicObjectInformation(aName, aDesc), startTime)
    {
        effectDuration = Duration;
        baseDamage = Damage;
        damageTickDuration = -DamageTickDuration;
    }

    public override void PerformBehavior(GameObject Player, GameObject obj)
    {
        StartCoroutine(DOT());
    }

    private IEnumerator DOT()
    {
        durationTimer.Start();
        while(durationTimer.Elapsed.TotalSeconds <= effectDuration)
        {
            // doDamage(list<targest>,baseDamage);
            yield return new WaitForSeconds(damageTickDuration);
        }

        durationTimer.Stop();
        durationTimer.Reset();
        yield return null;
    }
}

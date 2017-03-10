using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : Ability {

    /*
        Ranged:
            MaxDistance:
            MinDistance:
            RequiresTarget: true
            CanCastOnSelf: false 
    */

    private const string aName = "FireBall";
    private const string aDesc = "Fire projectile with AOE at impact";
    //private const Sprite icon = Resource.Load()   //path to sprite

    private const float baseEffectDamage = 2f;  //Fireball damage

    public FireBall() : base(new BasicObjectInformation(aName,aDesc))
    {
        this.Behaviors.Add(new Ranged(2f, 5f,3f, false));
        //this.Behaviors.Add(new AreaOfEffect(3f, 5f, baseEffectDamage));
        //this.Behaviors.Add(new DamageOverTime(10f, (baseEffectDamage / 2),5f));
    }
}

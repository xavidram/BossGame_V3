using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability {

    // Private Variables
    private BasicObjectInformation objInfo;
    private List<AbilityBehavior> behaviors;
    private bool requiresTarget;
    private bool canCastOnSelf;
    private int cooldownTime;
    private AbilityType type;
    // End Private Variables
   
    public enum AbilityType
    {
        Ranged, Melee
    }

    // Constructors
    public Ability(BasicObjectInformation BasicInfo, List<AbilityBehavior> Behaviors)
    {
        objInfo = BasicInfo;
        behaviors = new List<AbilityBehavior>();
        behaviors = Behaviors;
        requiresTarget = false;
        canCastOnSelf = false;
    }

    public Ability(BasicObjectInformation BasicInfo, List<AbilityBehavior> Behaviors, int CoolDownTime)
    {
        objInfo = BasicInfo;
        behaviors = new List<AbilityBehavior>();
        behaviors = Behaviors;
        cooldownTime = CoolDownTime;
        requiresTarget = false;
        canCastOnSelf = false;
    }

    public Ability(BasicObjectInformation BasicInfo, List<AbilityBehavior> Behaviors, int CoolDownTime, bool RequiresTarget, bool CanCastOnSelf)
    {
        objInfo = BasicInfo;
        behaviors = new List<AbilityBehavior>();
        behaviors = Behaviors;
        cooldownTime = CoolDownTime;
        requiresTarget = RequiresTarget;
        canCastOnSelf = CanCastOnSelf;
    }
    // End Constructors

    //Getters
    public BasicObjectInformation ObjectInformation
    {
        get { return objInfo; }
    }
    public List<AbilityBehavior> Behaviors
    {
        get { return behaviors; }
    }
    public int CoolDownTime
    {
        get { return cooldownTime; }
    }
    public bool RequiresTarget
    {
        get { return requiresTarget; }
    }
    public bool CanCastOnSelf
    {
        get { return canCastOnSelf; }
    }
    //End Getters

}

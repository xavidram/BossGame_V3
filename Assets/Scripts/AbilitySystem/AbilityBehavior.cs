using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityBehavior {

    private BasicObjectInformation objectInfo;
    private BehaviorStartTime startTime;

    public AbilityBehavior(BasicObjectInformation BasicInfo, BehaviorStartTime StartTime)
    {
        objectInfo = BasicInfo;
        startTime = StartTime;
    }

    public enum BehaviorStartTime
    {
        Beginning, Middle, End
    }

    //Pass in the object instead of position, for other effects
    public virtual void PerformBehavior(GameObject Player,GameObject obj)
    {
        Debug.LogWarning("Need To Add Behavior");
    }

    public BasicObjectInformation AbilityBehaviorInfo
    {
        get { return objectInfo; }
    }

    public BehaviorStartTime AbilityBehaviorStartTime
    {
        get { return startTime; }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityBehavior : MonoBehaviour {

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

    public virtual void PerformBehavior(Vector3 startPosition)
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Villager Dependent - Please Change.
public class Chop : Gather, IInteract {

    [SerializeField] private float _woodToGive;

    protected override bool GiveResource(Villager villager)
    {
        float rate = Time.deltaTime * villager._gatherRate;
        float woodLeft = _myResourceManager._wood._resourceStat.statValue - rate;
        float woodCollected = villager._wood.statValue + rate;

        if(woodLeft > 0)
        {
            if(woodCollected < villager._carryAmount)
            {
                villager._wood.statValue = woodCollected;
                _myResourceManager._wood._resourceStat.statValue = woodLeft;
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            if(woodCollected < villager._carryAmount)
            {
                villager._wood.statValue = _myResourceManager._wood._resourceStat.statValue;
                _myResourceManager._wood._resourceStat.statValue = 0;
                return false;
            }

            return false;
        }
    }
}
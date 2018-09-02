using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pick : Gather, IInteract {


    protected override bool GiveResource(Villager villager)
    {
        float rate = Time.deltaTime * villager._gatherRate;
        float foodLeft = _myResourceManager._food._resourceStat.statValue - rate;
        float foodCollected = villager._food.statValue + rate;

        if(foodLeft > 0)
        {
            if(foodCollected < villager._carryAmount)
            {
                villager._food.statValue = foodCollected;
                _myResourceManager._food._resourceStat.statValue = foodLeft;
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            if(foodCollected < villager._carryAmount)
            {
                villager._food.statValue = _myResourceManager._food._resourceStat.statValue;
                _myResourceManager._food._resourceStat.statValue = 0;
                return false;
            }

            return false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionManager : MonoBehaviour {

    //        UnitManager._selectedObject.GetComponent<Actor>().Engage(this, gameObject.transform.position);

    public IInteract[] GetValidInteractions(UnitManager.UnitType unitType)
    {
        IInteract[] interactions = GetComponents<IInteract>();
        List<IInteract> validInteractions = new List<IInteract>();

        for(int index = 0; index < interactions.Length; index++)
        {
            bool valid = false;

            UnitManager.UnitType[] validTypes = interactions[index].ValidUnitTypes;

            foreach(UnitManager.UnitType type in validTypes)
            {
                valid = unitType == type;
            }

            if(valid)
                validInteractions.Add(interactions[index]);
        }

        return validInteractions.ToArray();
    }
}

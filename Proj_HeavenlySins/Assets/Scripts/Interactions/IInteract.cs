using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteract {

    string Name { get; set; }
    InteractionManager MyInteractionManager { get; set; }
    float InteractionDistance { get; set; }
    UnitManager.UnitType[] ValidUnitTypes { get; set; }

    IEnumerator Interact();
}

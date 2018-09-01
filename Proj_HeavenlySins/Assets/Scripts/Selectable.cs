using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Selectable : MonoBehaviour {

    [HideInInspector] public bool _selected;
    private UIGod _uiGod;

    private void OnMouseDown()
    {
        if(Input.GetMouseButtonDown(0))
        {
            _selected = true;

            UnitManager._selectedObject = gameObject;

            IDisplay display = GetComponent<IDisplay>();
            if(display != null)
            {
                display.DisplayInformation();
            }
        }
    }

    private void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(1))
        {
            print("shit..");

            InteractionManager interactionManager;
            IInteract[] validInteractions = null;

            if(GetComponent<IInteract>() != null)
            {
                interactionManager = GetComponent<InteractionManager>();
                validInteractions = interactionManager.GetValidInteractions(UnitManager._selectedObject.GetComponent<Unit>()._unitType);
            }
            //IAct validActs = UnitManager._selectedObject.GetComponent<IAct>();

            if(validInteractions != null)
            {
                _uiGod = _uiGod == null ? GameObject.FindGameObjectWithTag("GameGod").GetComponent<UIGod>() : _uiGod;
                _uiGod.UpdateDropDownMenu(validInteractions, transform.position);
            }
        }
    }
}

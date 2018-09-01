using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionButton : MonoBehaviour {
    [HideInInspector] public IInteract _assignedInteraction;
    [HideInInspector] public UIGod _uiGod;
    [HideInInspector] public Vector2 _targetPos;
    public Text _buttonText;

    public void ConfirmButtonPress()
    {
        UnitManager._selectedObject.GetComponent<Actor>().LockInInteraction(_assignedInteraction, _targetPos);
        _uiGod.DisableDropDownMenu();
    }
}

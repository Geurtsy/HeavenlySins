using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameGod : MonoBehaviour 
{
    private UIGod _uiGod;

    private void Start()
    {
        _uiGod = GetComponent<UIGod>();
    }

    private void Update()
    {
        if(UnitManager._selectedObject == null)
        {
            _uiGod.DisableDropDownMenu();
        }
    }
}

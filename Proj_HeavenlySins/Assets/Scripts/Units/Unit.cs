using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Selectable))]
public class Unit : MonoBehaviour, IDisplay {

    public string _unitName;
    public string _unitDescription;
    public UnitManager.UnitType _unitType;

    [System.Serializable]
    public struct Stat
    {
        public string statName;
        public float statValue;
    }

    protected UnitInfo _unitInfo;

    private void Start()
    {
        _unitInfo = new UnitInfo();
    }

    public virtual void DisplayInformation()
    {
        _unitInfo.DisplayMyInfo(_unitName, _unitDescription);
    }
}

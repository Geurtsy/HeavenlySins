using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Actor))]
public class Villager : Unit {

    [SerializeField] private Stat _hunger;
    [SerializeField] private Stat _level;
    [SerializeField] private Stat _wood;
    [SerializeField] private Stat _food;
    [SerializeField] private Stat _stone;

    public override void DisplayInformation()
    {
        _unitInfo.DisplayMyInfo(_unitName, _unitDescription, new Stat[] { _hunger, _level, _wood, _food, _stone });
    }
}

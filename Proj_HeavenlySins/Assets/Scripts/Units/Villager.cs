using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(IMove))]
[RequireComponent(typeof(Actor))]
public class Villager : Unit {

    public float _gatherRate;

    public int _carryAmount;

    public Stat _hunger;
    public Stat _level;
    public Stat _wood;
    public Stat _food;
    public Stat _stone;

    public override void DisplayInformation()
    {
        _unitInfo.DisplayMyInfo(_unitName, _unitDescription, new Stat[] { _hunger, _level, _wood, _food, _stone });
    }
}

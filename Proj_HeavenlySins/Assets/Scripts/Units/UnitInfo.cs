using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitInfo {

    private List<string> _myInfoStrings;

    public void DisplayMyInfo(string unitName, string unitDescription, Unit.Stat[] stats)
    {
        _myInfoStrings = new List<string>();

        _myInfoStrings.Add("Name: " + unitName);
        _myInfoStrings.Add("Description: " + unitDescription);

        for(int index = 0; index < stats.Length; index++)
        {
            _myInfoStrings.Add(stats[index].statName + ": " + stats[index].statValue);
        }

        InformationDisplay._currentDisplayStrings = _myInfoStrings.ToArray();
    }

    public void DisplayMyInfo(string unitName, string unitDescription)
    {
        _myInfoStrings = new List<string>();

        _myInfoStrings.Add("Name: " + unitName);
        _myInfoStrings.Add("Description: " + unitDescription);

        InformationDisplay._currentDisplayStrings = _myInfoStrings.ToArray();
    }
}

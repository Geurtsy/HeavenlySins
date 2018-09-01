using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InformationDisplay : MonoBehaviour {

    public static string[] _currentDisplayStrings;
    private string[] _storedDisplayStrings;

    private List<Text> _activeDisplayTxt;

    [SerializeField] private GameObject _displayTextPrefab;
    [SerializeField] private Transform _informationPanel;

    private void Start()
    {
        _activeDisplayTxt = new List<Text>();
    }

    private void Update()
    {
        if(_storedDisplayStrings != _currentDisplayStrings)
            UpdateDisplayedInformation();
    }

    private void UpdateDisplayedInformation()
    {
        int activeTxtAmount = _activeDisplayTxt.Count;
        int amountToDisplay = _currentDisplayStrings.Length;
        _storedDisplayStrings = _currentDisplayStrings;

        if(activeTxtAmount >= amountToDisplay)
        {
            for(int index = activeTxtAmount - 1; index > amountToDisplay; index--)
            {
                Destroy(_activeDisplayTxt[index]);
            }
        }
        else
        {
            for(int index = activeTxtAmount - 1; index < amountToDisplay; index++)
            {
                _activeDisplayTxt.Add(Instantiate(_displayTextPrefab, _informationPanel).GetComponent<Text>());
            }
        }


        for(int index = 0; index < amountToDisplay; index++)
        {
            _activeDisplayTxt[index].text = _currentDisplayStrings[index];
        }
    }
}

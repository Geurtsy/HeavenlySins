using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour {

    [HideInInspector] public bool _dialogueComplete;
    [HideInInspector] public int _currentDialogueIndex;

    [TextArea]
    [SerializeField] private string[] _dialogue;

    [SerializeField] private TextMeshProUGUI _txtProDialogue;

    [SerializeField] private bool _doPlayOnStartup;

    private bool _continuePressed;

    private IEnumerator Start()
    {
        if(!_doPlayOnStartup)
        {
            while(!_continuePressed)
                yield return null;
        }

        yield return null;

        for(_currentDialogueIndex = 0; _currentDialogueIndex < _dialogue.Length; _currentDialogueIndex++)
        {
            _txtProDialogue.text = _dialogue[_currentDialogueIndex];

            while(!_continuePressed)
                yield return null;

            yield return null;
        }

        _dialogueComplete = true;
        _txtProDialogue.text = "";

        yield return null;
    }

    private void Update()
    {
        _continuePressed = false;

        if(Input.GetButtonDown("Continue"))
        {
            _continuePressed = true;
        }
    }
}

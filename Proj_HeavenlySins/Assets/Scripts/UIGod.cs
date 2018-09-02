using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGod : MonoBehaviour {

    [SerializeField] private GameObject _dropDownMenu;
    [SerializeField] private GameObject _interationMenuItemPrefab;
    private List<GameObject> _dropDownMenuItems;

    private void Start()
    {
        _dropDownMenuItems = new List<GameObject>();
    }

    public void UpdateDropDownMenu(IInteract[] interactions, Vector2 pos)
    {
        DisableDropDownMenu();

        _dropDownMenu.SetActive(true);

        foreach(IInteract interaction in interactions)
        {
            GameObject menuItem = Instantiate(_interationMenuItemPrefab, _dropDownMenu.transform);

            InitializeInterationButton(menuItem, interaction, pos);

            _dropDownMenuItems.Add(menuItem);
        }

        // _dropDownMenu.transform.position = pos;
    }

    public void DisableDropDownMenu()
    {

        if(_dropDownMenu.activeSelf == false)
            return;

        _dropDownMenu.SetActive(false);
        
        for(int index = 0; index < _dropDownMenuItems.Count; index++)
        {
            Destroy(_dropDownMenuItems[index].gameObject);
        }

        _dropDownMenuItems = new List<GameObject>();
    }
    
    private void InitializeInterationButton(GameObject menuItem, IInteract interaction, Vector2 interactionLocation)
    {
        InteractionButton interactionButton = menuItem.GetComponent<InteractionButton>();
        interactionButton._buttonText.text = interaction.Name;
        interactionButton._assignedInteraction = interaction;
        interactionButton._targetPos = interactionLocation;
        interactionButton._uiGod = this;

    }
}

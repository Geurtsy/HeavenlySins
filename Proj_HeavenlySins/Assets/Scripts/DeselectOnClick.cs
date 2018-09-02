using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DeselectOnClick : MonoBehaviour {

	public void OnMouseDown()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;

		Physics.Raycast(ray, out hit);

		if(hit.transform.GetComponent<Unit>() == null && EventSystem.current.IsPointerOverGameObject() == false)
		{
			print(hit.transform.gameObject);
			UnitManager._selectedObject = null;
		}
	}
}

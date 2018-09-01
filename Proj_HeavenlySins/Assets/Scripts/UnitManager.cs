using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitManager : MonoBehaviour {

    public enum UnitType { VILLAGER, RESOURCE, OTHER}

    public static GameObject _selectedObject;

    [SerializeField] private GameObject _babyPrefab;

    public void CreateNewVillager(Vector3 pos)
    {
        Instantiate(_babyPrefab, pos, Quaternion.identity);
    }
}

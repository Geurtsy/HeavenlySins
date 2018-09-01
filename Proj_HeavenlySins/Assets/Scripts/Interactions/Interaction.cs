using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(InteractionManager))]
public abstract class Interaction : MonoBehaviour, IInteract {
    [SerializeField] private string _interactionName;
    [SerializeField] private UnitManager.UnitType[] _validUnitTypes;
    public int _interactionLength;

    [SerializeField] private float _interactionDistance;

    public string Name
    {
        get
        {
            return _interactionName;
        }

        set
        {
            _interactionName = value;
        }
    }

    public InteractionManager MyInteractionManager
    {
        get;
        set;
    }

    public float InteractionDistance
    {
        get { return _interactionDistance; }
        set { _interactionDistance = value; }
    }

    public UnitManager.UnitType[] ValidUnitTypes
    {
        get
        {
            return _validUnitTypes;
        }

        set
        {
            _validUnitTypes = value;
        }
    }

    public virtual IEnumerator Interact()
    {
        yield return null;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour{

    private bool _engaged;
    public IInteract _engagedInteraction;
    private Vector3 _interactionPosition;

    public void LockInInteraction(IInteract interaction, Vector3 targetPos)
    {
        if(_engaged)
            Disengage();

        _engagedInteraction = interaction;
        _interactionPosition = targetPos;
        Engage();
    }

    public void Engage()
    {
        _engaged = true;
        _engagedInteraction.EngagedUnits.Add(this.gameObject);
        StartCoroutine(_engagedInteraction.Interact());
    }

    public void Disengage()
    {
        _engagedInteraction.EngagedUnits.Remove(this.gameObject);
        StopCoroutine(_engagedInteraction.Interact());
        _engaged = false;
    }
}

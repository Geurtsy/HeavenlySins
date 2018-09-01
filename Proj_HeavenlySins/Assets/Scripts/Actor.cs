using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour{

    private bool _engaged;
    private IInteract _engagedInteraction;
    private Vector3 _interactionPosition;

    [SerializeField] private float _movementSpeed;

    public void LockInInteraction(IInteract interaction, Vector3 targetPos)
    {
        _engagedInteraction = interaction;
        _interactionPosition = targetPos;
        StartCoroutine(Engage());
    }

    public IEnumerator Engage()
    {
        print("test");
        float distanceToInteraction = (_interactionPosition - transform.position).magnitude;

        while(_engagedInteraction.InteractionDistance < distanceToInteraction)
        {
            // Move.
            transform.position += (_interactionPosition - transform.position).normalized * _movementSpeed * Time.deltaTime;
            yield return null;
        }

        StartCoroutine(_engagedInteraction.Interact());

        yield return null;
    }

    public void Disengage()
    {
        StopAllCoroutines();
        StopCoroutine(_engagedInteraction.Interact());
        _engaged = false;
    }
}

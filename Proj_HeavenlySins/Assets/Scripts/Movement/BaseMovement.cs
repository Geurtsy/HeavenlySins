using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMovement : MonoBehaviour, IMove
{
	[SerializeField] private float _moveSpeed;

	public virtual void MoveTowardsTarget(Vector3 targetPos)
	{
		Vector3 directionToTarget = (targetPos - transform.position).normalized;
		
		transform.position += directionToTarget * Time.deltaTime * _moveSpeed;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : BaseMovement {

	public bool _move;

	[SerializeField] private float _range;
	[SerializeField] private float _accuracy;

	private void Start()
	{
		StartCoroutine(MoveRandomly());
	}

	private IEnumerator MoveRandomly()
	{
		float randomX = Random.Range(transform.position.x - _range, transform.position.x + _range);
		float randomY = Random.Range(transform.position.y - _range, transform.position.y + _range);
		Vector3 randomTarget = new Vector2(randomX, randomY);

		float disFromTarget = (transform.position - randomTarget).magnitude;

		while(disFromTarget > _accuracy)
		{
			MoveTowardsTarget(randomTarget);
			yield return null;
		}

		yield return null;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ResourceUnit))]
public class Gather : Interaction {

	[SerializeField] private float _gatherDistance;

	protected ResourceManager _myResourceManager;

	protected override void Start()
	{
		base.Start();
		_myResourceManager = GetComponent<ResourceUnit>()._resourceManager;
	}

	public override IEnumerator Interact()
	{
		base.Interact();

		print("Interacting");

		for(int index = 0; index < EngagedUnits.Count; index++)
		{
			GameObject unit = EngagedUnits[index];
			Vector3 unitPosition = unit.transform.position;
			float distanceFromUnit = Mathf.Abs((transform.position - unitPosition).magnitude);
			Villager villager = unit.GetComponent<Unit>().GetComponent<Villager>();
			IMove unitMover = villager.GetComponent<IMove>();
			Actor actor = villager.GetComponent<Actor>();

			while(distanceFromUnit > _gatherDistance && (Interaction)actor._engagedInteraction == this)
			{
				unitMover.MoveTowardsTarget(transform.position);
				print(this.gameObject);

				unitPosition = unit.transform.position;
				distanceFromUnit = Mathf.Abs((transform.position - unitPosition).magnitude);
				yield return null;
			}

			while(GiveResource(villager) && (Interaction)actor._engagedInteraction == this)
			{
				yield return null;
			}
			
			if((Interaction)actor._engagedInteraction == this)
				villager.GetComponent<Actor>().Disengage();
			yield return null;
		}

		yield return null;
	}

	protected virtual bool GiveResource(Villager villager)
	{
		return false;
	}
}

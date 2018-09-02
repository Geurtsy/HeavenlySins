using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood : ResourceUnit {

	public override void DisplayInformation()
	{
		_unitInfo.DisplayMyInfo(_unitName, _unitDescription, new Stat[] {_resourceManager._wood._resourceStat} );
	}
}

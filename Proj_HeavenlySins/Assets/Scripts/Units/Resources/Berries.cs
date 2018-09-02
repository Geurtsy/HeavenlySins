using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Berries : ResourceUnit {

	public override void DisplayInformation()
	{
		_unitInfo.DisplayMyInfo(_unitName, _unitDescription, new Stat[] { _resourceManager._food._resourceStat } );
	}
}

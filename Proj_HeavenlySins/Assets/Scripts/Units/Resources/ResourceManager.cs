using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ResourceManager {

	[System.Serializable]
	public struct Resource
	{
		public Unit.Stat _resourceStat;
		public bool _isValidResource;
		public float _maxValue;
	}

	public Resource _wood;
	public Resource _food;
	public Resource _stone;
}

﻿using UnityEngine;
using System.Collections;

public class WarFactory : Building 
{
	protected override void Start () 
	{
		base.Start();
		actions = new string[] { "Tank" };
	}

	public override void PerformAction(string actionToPerform) {
		base.PerformAction(actionToPerform);
		CreateUnit(actionToPerform);
	}
}

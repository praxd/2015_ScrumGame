﻿using UnityEngine;
using System.Collections;
using Prime31.StateKit;

public class Girl_OnAirState : SKMecanimState<GirlController>
{
	public override void begin ()
	{
		base.begin ();
	}
	
	public override void reason ()
	{
		base.reason ();

		/*float horizontal = Input.GetAxis("Horizontal");*/
		float vertical = Input.GetAxis("Vertical");

		if(vertical == 0.0f){
			_machine.changeState<Girl_LandState>();
			return;
		}
	}
	
	
	
	#region implemented abstract members of SKMecanimState
	public override void update (float deltaTime, AnimatorStateInfo stateInfo)
	{

	}
	#endregion
	
	public override void end ()
	{
		base.end ();
	}
}

﻿using UnityEngine;
using System.Collections;
using Prime31.StateKit;

public class Panda_IdleState : SKMecanimState<PandaController> {

	public override void begin ()
	{
		base.begin ();
		
		//Tocar animacao IDLE.
		//Parar o personagem.
	}

	public override void reason ()
	{
		base.reason ();
		
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");
		
		if(horizontal != 0.0f)
		{
			_machine.changeState<Panda_RunState>();
			return;
		}
		if(vertical > 0.0f){
			_machine.changeState<Panda_JumpState>();
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

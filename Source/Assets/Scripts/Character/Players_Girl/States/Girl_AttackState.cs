﻿using UnityEngine;
using System.Collections;
using Prime31.StateKit;

public class Girl_AttackState : SKMecanimState<GirlController>
{
	float timeOnState;

	public override void begin () {
		base.begin();
		timeOnState = 0;
		Debug.Log("Im attacking, bitch!");
		_machine.animator.Play("Attack");

		_context.physicsController.SetVelocity(Vector2.zero);
	}
	
	public override void reason (){
		base.reason();

		if(timeOnState > 0.5f){

			float horizontal = Input.GetAxis("Horizontal");

			if(horizontal == 0){
				_machine.changeState<Girl_IdleState>();
				return;
			}else if(horizontal != 0){
				_machine.changeState<Girl_RunState>();
				return;
			}
		}
	}
	
	#region implemented abstract members of SKMecanimState
	public override void update (float deltaTime, AnimatorStateInfo stateInfo)
	{
		timeOnState += deltaTime;
	}
	#endregion
	
	public override void end (){
		base.end();
	}
}

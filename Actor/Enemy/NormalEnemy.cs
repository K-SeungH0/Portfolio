using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalEnemy : Enemy
{
	public override void Init(bool i = false)
	{
		base.Init();

	}

	public override void PlayAnimation(string animation_name, Action OnCompleted, bool is_check_end_animation = false)
	{
		base.PlayAnimation(animation_name, OnCompleted, is_check_end_animation);
	}
}

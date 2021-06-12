using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
	/// <summary>
	/// 
	/// </summary>
	public class MovingPlatform : Barrier
	{
        protected override void AppealingEffect()
        {
            base.AppealingEffect();
            PlayerInputController.Instance.transform.parent = this.transform;
        }
    }
}
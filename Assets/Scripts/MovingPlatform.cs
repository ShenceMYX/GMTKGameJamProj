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
        private bool isAppealed = false;
        private float moveSpeed = 0.3f;

        protected override void AppealingEffect()
        {
            base.AppealingEffect();
            PlayerInputController.Instance.transform.parent = this.transform;
            isAppealed = true;
        }

        protected override void CancelAppealing()
        {
            base.CancelAppealing();
            PlayerInputController.Instance.transform.parent = null;
            isAppealed = false;
        }

        public new void Update()
        {
            base.Update();
            if (isAppealed)
            {
                if (Input.GetKey(KeyCode.RightArrow))
                {
                    transform.Translate(Vector3.right * moveSpeed);
                }
                else if (Input.GetKey(KeyCode.LeftArrow))
                {
                    transform.Translate(-Vector3.right * moveSpeed);
                }
            }
        }
    }
}
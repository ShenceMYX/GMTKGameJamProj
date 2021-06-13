using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Common;

namespace Player
{
	/// <summary>
	/// 
	/// </summary>
	public class MovingPlatform : Barrier
	{
        public  float rangeMax;
        public float rangeMin;
        private bool isAppealed = false;
        public float moveSpeed = 0.05f;

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

                //if(transform.position.x>rangeMax) transform.position=new Vector3(rangeMax,transform.position.y,transform.position.z);

             Vector3 temp=transform.position;
             temp.x=Mathf.Clamp(transform.position.x,rangeMin,rangeMax);
            transform.position=new Vector3(temp.x,transform.position.y,transform.position.z);
            }
            
        }

        private void OnCollisionEnter2D(Collision2D other){
        Debug.Log("!!!!!!!!!!!!!11111110");
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Common;

namespace Player
{
	/// <summary>
	/// 
	/// </summary>
	public class MovingPlatformH : Barrier
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
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    transform.Translate(Vector3.up * moveSpeed);
                }
                else if (Input.GetKey(KeyCode.DownArrow))
                {
                    transform.Translate(-Vector3.up * moveSpeed);
                }

                //if(transform.position.x>rangeMax) transform.position=new Vector3(rangeMax,transform.position.y,transform.position.z);

             Vector3 temp=transform.position;
             temp.y=Mathf.Clamp(transform.position.y,rangeMin,rangeMax);
            transform.position=new Vector3(transform.position.x,temp.y,transform.position.z);
            }
            
        }

        private void OnCollisionEnter2D(Collision2D other){
        Debug.Log("!!!!!!!!!!!!!11111110");
        }
    }
}
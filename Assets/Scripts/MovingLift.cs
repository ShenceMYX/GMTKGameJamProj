using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
	/// <summary>
	/// 
	/// </summary>
	public class MovingLift : Barrier
	{
        private bool isAppealed = false;
        public float moveSpeed = 0.03f;

        public Transform[] wayPoints;
        public bool isMovingOnce = true;
        public int currentIndex = 1;

        private float startTime;
        public float timeInterval = 3f;

        private void Awake()
        {
            transform.position = wayPoints[0].position;
        }

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
            if (isMovingOnce)
            {
                if (isAppealed)
                {
                    transform.position = Vector3.MoveTowards(transform.position, wayPoints[wayPoints.Length - 1].position, moveSpeed);
                }
            }
            else
            {
                if(Vector3.Distance(transform.position, wayPoints[currentIndex].position) < 1f)
                {
                    if (currentIndex >= wayPoints.Length - 1)
                    {
                        currentIndex = 0;
                    }else{
                    currentIndex++;
                    }
                    startTime = timeInterval + Time.time;
                   
                }
                if (startTime < Time.time) 
                    transform.position = Vector3.MoveTowards(transform.position, wayPoints[currentIndex].position, moveSpeed);
            }
            
        }
    }
}
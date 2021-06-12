using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
	/// <summary>
	/// 玩家角色输入控制类
	/// </summary>
	public class PlayerInputController : MonoBehaviour
	{
        public PoleStatus UpPoleStatus  = PoleStatus.None;
        public PoleStatus DownPoleStatus  = PoleStatus.None;
        public PoleStatus LeftPoleStatus  = PoleStatus.None;
        public PoleStatus RightPoleStatus = PoleStatus.None;

        private void Update()
        {
            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
            {
                if (Input.GetKeyDown(KeyCode.W))
                {
                    if (UpPoleStatus != PoleStatus.SouthPole)
                        UpPoleStatus = PoleStatus.SouthPole;
                    else
                        UpPoleStatus = PoleStatus.None;
                }
                else if (Input.GetKeyDown(KeyCode.S))
                {
                    if (DownPoleStatus != PoleStatus.SouthPole)
                        DownPoleStatus = PoleStatus.SouthPole;
                    else
                        DownPoleStatus = PoleStatus.None;
                }
                else if (Input.GetKeyDown(KeyCode.A))
                {
                    if (LeftPoleStatus != PoleStatus.SouthPole)
                        LeftPoleStatus = PoleStatus.SouthPole;
                    else
                        LeftPoleStatus = PoleStatus.None;
                }
                else if (Input.GetKeyDown(KeyCode.D))
                {
                    if (RightPoleStatus != PoleStatus.SouthPole)
                        RightPoleStatus = PoleStatus.SouthPole;
                    else
                        RightPoleStatus = PoleStatus.None;
                }
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.W))
                {
                    if (UpPoleStatus != PoleStatus.NorthPole)
                        UpPoleStatus = PoleStatus.NorthPole;
                    else
                        UpPoleStatus = PoleStatus.None;
                }
                else if (Input.GetKeyDown(KeyCode.S))
                {
                    if (DownPoleStatus != PoleStatus.NorthPole)
                        DownPoleStatus = PoleStatus.NorthPole;
                    else
                        DownPoleStatus = PoleStatus.None;
                }
                else if (Input.GetKeyDown(KeyCode.A))
                {
                    if (LeftPoleStatus != PoleStatus.NorthPole)
                        LeftPoleStatus = PoleStatus.NorthPole;
                    else
                        LeftPoleStatus = PoleStatus.None;
                }
                else if (Input.GetKeyDown(KeyCode.D))
                {
                    if (RightPoleStatus != PoleStatus.NorthPole)
                        RightPoleStatus = PoleStatus.NorthPole;
                    else
                        RightPoleStatus = PoleStatus.None;
                }
            }
           
        }
    }
}
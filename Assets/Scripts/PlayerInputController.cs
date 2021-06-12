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
        public PoleStatus UpPoleStatus { get; set; } = PoleStatus.None;
        public PoleStatus DownPoleStatus { get; set; } = PoleStatus.None;
        public PoleStatus LeftPoleStatus { get; set; } = PoleStatus.None;
        public PoleStatus RightPoleStatus { get; set; } = PoleStatus.None;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                if(UpPoleStatus == PoleStatus.NorthPole)
                    UpPoleStatus = PoleStatus.None;
                else
                    UpPoleStatus = PoleStatus.NorthPole;
            }
        }
    }
}
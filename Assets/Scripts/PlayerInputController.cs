using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Common;

namespace Player
{
	/// <summary>
	/// 玩家角色输入控制类
	/// </summary>
	public class PlayerInputController : MonoSingleton<PlayerInputController>
	{
        public PoleStatus UpPoleStatus  = PoleStatus.None;
        public PoleStatus DownPoleStatus  = PoleStatus.None;
        public PoleStatus LeftPoleStatus  = PoleStatus.None;
        public PoleStatus RightPoleStatus = PoleStatus.None;

        private Animator upPoleAnim;
        private Animator downPoleAnim;
        private Animator leftPoleAnim;
        private Animator rightPoleAnim;

        private void Start()
        {
            upPoleAnim = transform.GetChild(1).GetComponentInChildren<Animator>();
            rightPoleAnim = transform.GetChild(2).GetComponentInChildren<Animator>();
            downPoleAnim = transform.GetChild(3).GetComponentInChildren<Animator>();
            leftPoleAnim = transform.GetChild(4).GetComponentInChildren<Animator>();
        }

        private void Update()
        {
            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
            {
                if (Input.GetKeyDown(KeyCode.W))
                {
                    if (UpPoleStatus != PoleStatus.SouthPole)
                    {
                        if (UpPoleStatus == PoleStatus.None)
                            upPoleAnim.SetTrigger("southUp");
                        else
                            upPoleAnim.SetTrigger("north2south");
                        UpPoleStatus = PoleStatus.SouthPole;
                    }
                    else
                    {
                        upPoleAnim.SetTrigger("southDown");
                        UpPoleStatus = PoleStatus.None;
                    }
                }
                else if (Input.GetKeyDown(KeyCode.S))
                {
                    if (DownPoleStatus != PoleStatus.SouthPole)
                    {
                        if (DownPoleStatus == PoleStatus.None)
                            downPoleAnim.SetTrigger("southUp");
                        else
                            downPoleAnim.SetTrigger("north2south");
                        DownPoleStatus = PoleStatus.SouthPole;
                    }
                    else
                    {
                        downPoleAnim.SetTrigger("southDown");
                        DownPoleStatus = PoleStatus.None;
                    }
                }
                else if (Input.GetKeyDown(KeyCode.A))
                {
                    if (LeftPoleStatus != PoleStatus.SouthPole)
                    {
                        if (LeftPoleStatus == PoleStatus.None)
                            leftPoleAnim.SetTrigger("southUp");
                        else
                            leftPoleAnim.SetTrigger("north2south");
                        LeftPoleStatus = PoleStatus.SouthPole;
                    }
                    else
                    {
                        leftPoleAnim.SetTrigger("southDown");
                        LeftPoleStatus = PoleStatus.None;
                    }
                }
                else if (Input.GetKeyDown(KeyCode.D))
                {
                    if (RightPoleStatus != PoleStatus.SouthPole)
                    {
                        if (RightPoleStatus == PoleStatus.None)
                            rightPoleAnim.SetTrigger("southUp");
                        else
                            rightPoleAnim.SetTrigger("north2south");
                        RightPoleStatus = PoleStatus.SouthPole;
                    }
                    else
                    {
                        rightPoleAnim.SetTrigger("southDown");
                        RightPoleStatus = PoleStatus.None;
                    }
                }
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.W))
                {
                    if (UpPoleStatus != PoleStatus.NorthPole)
                    {
                        if (UpPoleStatus == PoleStatus.None)
                            upPoleAnim.SetTrigger("northUp");
                        else
                            upPoleAnim.SetTrigger("south2north");
                        UpPoleStatus = PoleStatus.NorthPole;
                    }
                    else
                    {
                        upPoleAnim.SetTrigger("northDown");
                        UpPoleStatus = PoleStatus.None;
                    }
                }
                else if (Input.GetKeyDown(KeyCode.S))
                {
                    if (DownPoleStatus != PoleStatus.NorthPole)
                    {
                        if (DownPoleStatus == PoleStatus.None)
                            downPoleAnim.SetTrigger("northUp");
                        else
                            downPoleAnim.SetTrigger("south2north");
                        DownPoleStatus = PoleStatus.NorthPole;
                    }
                    else
                    {
                        DownPoleStatus = PoleStatus.None;
                        downPoleAnim.SetTrigger("northDown");
                    }
                }
                else if (Input.GetKeyDown(KeyCode.A))
                {
                    if (LeftPoleStatus != PoleStatus.NorthPole)
                    {
                        if (LeftPoleStatus == PoleStatus.None)
                            leftPoleAnim.SetTrigger("northUp");
                        else
                            leftPoleAnim.SetTrigger("south2north");
                        LeftPoleStatus = PoleStatus.NorthPole;
                    }
                    else
                    {
                        LeftPoleStatus = PoleStatus.None;
                        leftPoleAnim.SetTrigger("northDown");
                    }
                }
                else if (Input.GetKeyDown(KeyCode.D))
                {
                    if (RightPoleStatus != PoleStatus.NorthPole)
                    {
                        if (RightPoleStatus == PoleStatus.None)
                            rightPoleAnim.SetTrigger("northUp");
                        else
                            rightPoleAnim.SetTrigger("south2north");
                        RightPoleStatus = PoleStatus.NorthPole;
                    }
                    else
                    {
                        RightPoleStatus = PoleStatus.None;
                        rightPoleAnim.SetTrigger("northDown");
                    }
                }
            }


            
           
        }
    }
}
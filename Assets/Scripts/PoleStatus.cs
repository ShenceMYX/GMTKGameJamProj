using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
	/// <summary>
	/// 南北极状态枚举
	/// </summary>
	public enum PoleStatus
	{
		//北极
		NorthPole,
		//南极
		SouthPole,
		//无磁极
		None
	}
	public enum Direction
	{
		//北极
		Up,
		//南极
		Down,
		//无磁极
		Left,
		Right
	}
}
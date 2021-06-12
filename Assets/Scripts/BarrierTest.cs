using System.Collections;
using System.Collections.Generic;
using Player;
using UnityEngine;


namespace ns
{
	/// <summary>
	/// 
	/// </summary>
	public class BarrierTest : MonoBehaviour
	{
        private void Update()
        {
            Debug.Log(PlayerInputController.Instance.gameObject.name);
        }
    }
}
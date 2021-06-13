using System.Collections;
using System.Collections.Generic;
using Common;
using UnityEngine;

namespace ns
{
    /// <summary>
    /// 
    /// </summary>
    public class UIController : MonoSingleton<UIController>
    {
        public int coinCount = 0;

        private void Update()
        {
            if (coinCount > 3) return;
            for (int i = 0; i < coinCount; i++)
            {
                transform.GetChild(i).GetChild(1).gameObject.SetActive(true);
            }
        }
    }
}
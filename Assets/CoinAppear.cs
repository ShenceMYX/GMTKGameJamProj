using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ns
{
	/// <summary>
	/// 
	/// </summary>
	public class CoinAppear : MonoBehaviour
	{
        public int count = 1;

        private float startDelay = 0.5f;

        private float bulbDelay = 1f;
       

        private void Update()
        {
            startDelay -= Time.deltaTime;
            if (startDelay < 0)
            {
                bulbDelay -= Time.deltaTime;
                for (int i = 0; i < UIController.Instance.coinCount; i++)
                {
                    switch (i)
                    {
                        case 0:
                            transform.GetChild(i).gameObject.SetActive(true);
                            break;
                        case 1:
                            if(bulbDelay<0.5)
                                transform.GetChild(i).gameObject.SetActive(true);
                            break;
                        case 2:
                            if(bulbDelay<0)
                                transform.GetChild(i).gameObject.SetActive(true);
                            break;
                        default:
                            break;
                    }
                }
            }        
        }
    }
}
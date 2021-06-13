using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ns
{
    /// <summary>
    /// 
    /// </summary>
    public class PickUpCoin : MonoBehaviour
    {
        public AudioClip PickUp;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {
                UIController.Instance.coinCount++;
                AudioSource.PlayClipAtPoint(PickUp,this.transform.position);
                Destroy(gameObject);
            }
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Player;

public class StingRange : MonoBehaviour
{
   public GameObject bloodFx;
   private float duration = 1f;
   private bool startCount = false;

   private AudioSource source;

   private void Start(){
       source = GetComponent<AudioSource>();
   }
    void OnTriggerEnter2D(Collider2D other)
    
    {
        Debug.Log("Enter!");
        if (other.gameObject.tag=="Player")
        {
            source.Play();
            PlayerInputController.Instance.GetComponentInChildren<Animator>().SetTrigger("Death");
            Instantiate(bloodFx, PlayerInputController.Instance.gameObject.transform.position, Quaternion.identity);
            startCount = true;
        }
        
        
    }

    private void Update(){
        if(startCount){
            duration-=Time.deltaTime;
            if(duration<0){
            SceneManager.LoadScene(1);
            }
        }
    }
}

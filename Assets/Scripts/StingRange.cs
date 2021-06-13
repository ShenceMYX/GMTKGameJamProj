using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Player;

public class StingRange : MonoBehaviour
{
   private float duration = 1f;
   private bool startCount = false;
    void OnTriggerEnter2D(Collider2D other)
    
    {
        Debug.Log("Enter!");
        if (other.gameObject.tag=="Player")
        {
            PlayerInputController.Instance.GetComponentInChildren<Animator>().SetTrigger("Death");
            
            startCount = true;
        }
        
        
    }

    private void Update(){
        if(startCount){
            duration-=Time.deltaTime;
            if(duration<0){
            SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
            }
        }
    }
}

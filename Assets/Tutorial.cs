using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    private SpriteRenderer renderer;

    private void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D o){
        if(o.CompareTag("Player")){
            renderer.enabled=true;
        }
    }
    private void OnTriggerExit2D(Collider2D o){
           if(o.CompareTag("Player")){
            renderer.enabled=false;
        }
    }
}

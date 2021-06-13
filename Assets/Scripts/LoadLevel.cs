using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadLevel : MonoBehaviour
{
    private float duration = 3f;

    private AudioSource source;

    private bool playAu = false;

    private void Start(){
        source=GetComponent<AudioSource>();
    }
    public void LoadLevelOne(){
            SceneManager.LoadScene(1);
    }

    private void Update(){
        duration-=Time.deltaTime;
        if(duration<1&&!playAu){source.Play();playAu=true;}
        if(duration<0)
        LoadLevelOne();
    }
}

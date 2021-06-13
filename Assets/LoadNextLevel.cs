using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextLevel : MonoBehaviour
{
  public GameObject loadNextLevelGO;
  private bool startPlayTransAnim = false;
  public float timeCount = 3f;
  private void OnTriggerEnter2D(Collider2D other)
  {
      if(other.CompareTag("Player"))
      {
          startPlayTransAnim = true;
          loadNextLevelGO.SetActive(true);
      }
  }

  private void Update()
  {
      if(startPlayTransAnim){
          timeCount-=Time.deltaTime;
          if(timeCount<0){
            SceneManager.LoadScene(2);
          }
      }
  }
}

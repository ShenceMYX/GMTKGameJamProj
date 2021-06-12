using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Common;

namespace Player
{
public class Barrier : MonoBehaviour
{
    // Start is called before the first frame update
public Direction barrierDirection;
public PoleStatus Required; 
private PoleStatus Resisted;
private GameObject Player;
    void Start()
    {
        Player = PlayerInputController.Instance.gameObject;
        Resisted=(PoleStatus) (((int)Required+1)%2) ;
        
    }

    // Update is called once per frame
    void Update()
    {
         Debug.Log(gameObject.name+" "+gameObject.GetComponent<BoxCollider2D>().bounds.Contains(Player.transform.position));
         //Debug.Log(gameObject.name+" "+gameObject.GetComponent<BoxCollider2D>().bounds.center+" "+gameObject.GetComponent<BoxCollider2D>().bounds.size +" "+Player.transform.position);
        if (gameObject.GetComponent<BoxCollider2D>().bounds.Contains(Player.transform.position))
        {
            Debug.Log(barrierDirection==Direction.Left);
            if (barrierDirection==Direction.Down)            
            {
                 if (PlayerInputController.Instance.DownPoleStatus==Required)                 
                    Player.GetComponent<Rigidbody2D>().velocity=new Vector2(0.0f,-10.0f);
                 else  if (PlayerInputController.Instance.DownPoleStatus==Resisted)                 
                    Player.GetComponent<Rigidbody2D>().velocity=new Vector2(0.0f,10.0f);
            }

            if (barrierDirection==Direction.Up)            
            {
                 if (PlayerInputController.Instance.UpPoleStatus==Required)                 
                    Player.GetComponent<Rigidbody2D>().velocity=new Vector2(0.0f,10.0f);
                else  if (PlayerInputController.Instance.UpPoleStatus==Resisted)                 
                    Player.GetComponent<Rigidbody2D>().velocity=new Vector2(0.0f,-10.0f);
            }

            if (barrierDirection==Direction.Left)            
            {
                Debug.Log("Left");
                 if (PlayerInputController.Instance.LeftPoleStatus==Required)                 
                    Player.GetComponent<Rigidbody2D>().velocity=new Vector2(10.0f,0.0f);
                    else  if (PlayerInputController.Instance.LeftPoleStatus==Resisted)                 
                    Player.GetComponent<Rigidbody2D>().velocity=new Vector2(-10.0f,0.0f);
            } 

            if (barrierDirection==Direction.Right)            
            {
                 if (PlayerInputController.Instance.RightPoleStatus==Required)                 
                    Player.GetComponent<Rigidbody2D>().velocity=new Vector2(-10.0f,0.0f);
                if (PlayerInputController.Instance.RightPoleStatus==Resisted)                 
                    Player.GetComponent<Rigidbody2D>().velocity=new Vector2(10.0f,0.0f);
            } 
            }

        
    }
}
}

    
   // void OnTriggerStay2D(Collider2D other)
    // {
    //     Debug.Log ("DebugEnter"); 
    //     if (BarrierDrection==1)  
    //     {
           
    //         if (other.gameObject.GetComponent<PlayerInputController>().UpPoleStatus==Required)
    //         {
                
    //             Debug.Log ("testtest");  
    //             //other.GetComponent<Rigidbody2D>().velocity=new Vector2(0.0f,1.0f);
               
    //          }  
    //        }

    //       if (BarrierDrection==2)  
    //     {
    //         if (other.GetComponent<PlayerInputController>().RightPoleStatus==Required)
    //             other.gameObject.GetComponent<Rigidbody2D>().velocity=new Vector2(1.0f,0.0f);
    //     }

    //       if (BarrierDrection==3)  
    //     {
    //         if (other.GetComponent<PlayerInputController>().LeftPoleStatus==Required)
    //             other.GetComponent<Rigidbody2D>().velocity=new Vector2(-1.0f,0.0f);
    //     }

    //       if (BarrierDrection==4)  
    //     {
    //         if (other.GetComponent<PlayerInputController>().DownPoleStatus==Required)
    //             other.GetComponent<Rigidbody2D>().velocity=new Vector2(0.0f,-1.0f);
    //     }
        
    // }
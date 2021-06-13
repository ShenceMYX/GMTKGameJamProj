using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Player;

public class AutoMoving : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float rangeMin;
    public float rangeMax;


    void Update()
    {
         transform.Translate(Vector3.right*speed*Time.deltaTime);
        if((transform.position.x<rangeMin)||(transform.position.x>rangeMax))
        {speed*=-1;}
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Player;

public class Auto : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float rangeMin;
    public float rangeMax;


    void Update()
    {
         transform.Translate(Vector3.up*speed*Time.deltaTime);
        if((transform.position.y<rangeMin)||(transform.position.y>rangeMax))
        {speed*=-1;}
    }
}

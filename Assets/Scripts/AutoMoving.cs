using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMoving : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float rangeMin;
    public float rangeMax;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
         transform.Translate(Vector3.right*speed*Time.deltaTime);
        if(transform.position.x<rangeMin||transform.position.x>rangeMax)
        {speed*=-1;}
    }
}

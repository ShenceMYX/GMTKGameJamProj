using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingToghther : MonoBehaviour
{
   
    void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log( other.transform.parent);
        other.transform.parent = this.transform;
        //Debug.Log( other.transform.parent);
    }

    // void OnTriggerExit2D(Collider2D other)
    // {
    //     Debug.Log("Exit");
    //     other.transform.parent=null;
    // }


}

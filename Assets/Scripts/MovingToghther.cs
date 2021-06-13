using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingToghther : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Enter");
        other.transform.parent = this.transform;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("Exit");
        other.transform.parent=null;
    }


}

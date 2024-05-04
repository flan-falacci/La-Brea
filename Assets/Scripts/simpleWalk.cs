using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleWalk : MonoBehaviour
{
    public float speed;
  

    void Start()
    {
     // yPos = transform.position.y;    
    }

    void Update()
    {
           
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += -transform.right * Time.deltaTime *  speed;
            
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right *Time.deltaTime * speed; 
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime * speed; 
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += -transform.forward * Time.deltaTime * speed;
        }
    }
}

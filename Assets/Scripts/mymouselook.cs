using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class mymouselook : MonoBehaviour
{

    public GameObject cameraObj;
    Transform myCam; 

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

             myCam = cameraObj.transform; 

            // rotate camera based on mouse delta speed... X axis is vertical mouse, Y axis is horizontal mouse
            myCam.Rotate(-Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0f);

            // unroll our camera's Z angle
            myCam.localEulerAngles = new Vector3(myCam.localEulerAngles.x, myCam.localEulerAngles.y, 0f);
        }
    
}

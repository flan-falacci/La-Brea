using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public GameObject leftDoor;
    public GameObject rightDoor;

    public Animator leftAnim;
    public Animator rightAnim;

    // Start is called before the first frame update
    void Start()
    {
        leftAnim.SetBool("opening", false);
        rightAnim.SetBool("opening", false);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //play door opening animation
            leftAnim.SetBool("opening", true);
            rightAnim.SetBool("opening", true);

            Camera.main.clearFlags = CameraClearFlags.Color;
            Camera.main.backgroundColor = Color.black;
        }
    }


}

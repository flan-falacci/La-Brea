using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sinkSimple : MonoBehaviour
{
    float speed; 
    // Start is called before the first frame update
    void Start()
    {
        speed = .5f; 
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += new Vector3(0, -1, 0) * Time.deltaTime * speed; 
    }
}

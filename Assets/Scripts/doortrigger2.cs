using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doortrigger2 : MonoBehaviour
{

    public GameObject outsideZone;
    public GameObject museum; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            outsideZone.SetActive(false);
            museum.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorTracker : MonoBehaviour
{
    public static bool doorDetect;

    private void Start()
    {
        doorDetect = false;
    }


    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "FirstPersonPlayer")
        {
            doorDetect = true;
            Debug.Log("Walked into room");
            other.tag = "Untagged";
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUp : MonoBehaviour
{
    public Transform theDest;

    void OnMouseDown()
    {
        GetComponent<Collider>().enabled = false;
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.position = theDest.position;
        this.transform.parent = GameObject.Find("Destination").transform;
    }

    private void OnMouseUp()
    {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<Collider>().enabled = true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bookTracker : MonoBehaviour
{
    public static bool bookPlaced;

    private void Start()
    {
        bookPlaced = false;
    }   


    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "book")
        {
            bookPlaced = true;
            Debug.Log("book placed");
            other.tag = "Untagged";
        }
    }
}

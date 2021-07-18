using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tidyTracker : MonoBehaviour
{
    public static int tidyQuest;
    

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Selectable")
        {
            tidyQuest++;
            Debug.Log(tidyQuest);
            other.tag = "Untagged";
        }
    }
}

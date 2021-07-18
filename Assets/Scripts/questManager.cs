using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class questManager : MonoBehaviour
{
    private static int tidyQuest;
    private bool findBook;
    private bool bookPlaced;
    private bool intoRoom;
    private bool jesus;
    public Text tidyText;
    public Text bookText;
    public Text bookPlacedText;
    public Text roomText;
    public Text jesusText;
    private bool firstQuest;
    private bool secondQuest;
    private bool thirdQuest;
    private bool fourthQueste;
    private bool fifthQuest;
    public MeshRenderer Door;
    public Collider ColliderDoor;

    private void Start()
    {
        tidyQuest = 0;
        firstQuest = false;
        secondQuest = false;
        thirdQuest = false;
        fourthQueste = false;
        fifthQuest = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (tidyQuest < 3)
        {
            tidyQuest = tidyTracker.tidyQuest;
            tidyText.text = "1.Tidy up area " + tidyQuest + "/3";
        }

        else
        {
            firstQuest = true;
            tidyText.text = "1.Tidy up area 3/3 (Done)";
        }

        if (findBook == false)
        {
            findBook = SelectionManager.findBook;
        }
            
        else
        {
            secondQuest = true;
            bookText.text = "2. Find bible (Done)";
        }

        if (bookPlaced == false)
        {
            bookPlaced = bookTracker.bookPlaced;
        }

        else
        {
            thirdQuest = true;
            bookPlacedText.text = "3. Put bible on pedestal (Done)";
            if (firstQuest == true && secondQuest == true && thirdQuest == true)
            {
                Door.enabled = false;
                ColliderDoor.enabled = false;
            }
        }

        if (intoRoom==false)
        {
            intoRoom = doorTracker.doorDetect;
        }

        else
        {
            fourthQueste = true;
            roomText.text = "4. Go into stairs room (Done)";
        }

        if (jesus == false)
        {
            jesus = SelectionManager.findJesus;
        }

        else
        {
            fifthQuest = true;
            jesusText.text = "5. Look at Jesus (Done)";
        }

    }
        
}

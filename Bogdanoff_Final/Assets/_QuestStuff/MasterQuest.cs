using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MasterQuest : MonoBehaviour
{
    public PlayerQuests playerQuests;

    public bool chickenQStarted = false;
    public bool chickenQComp = false;

    public bool turtleQStarted = false;
    public bool turtleQComp = false;
    public Text turtText;
    public Text turtStrike;

    public bool birdQStarted = false; 
    public bool birdQComp = false;

    void Start()
    {
        turtText.text = "";
        turtStrike.text = "";
    }

    void Update()
    {
        if (turtleQStarted == true)
        {
            turtText.text = "Collect 3 flowers";
        }

         if (playerQuests.turtFlowerCount == 3)
        {
            turtStrike.enabled = true;
            turtleQComp = true;
        }

         if (turtleQComp == true)
        {
            turtStrike.text = "_______________________";
        }
    }
}






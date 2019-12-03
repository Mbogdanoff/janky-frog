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

    public Image turtStrike;

    public bool birdQStarted = false;
    public bool birdQComp = false;

    void Start()
    {
        turtText.text = "";
    }

    void Update()
    {
        if (turtleQStarted == true)
        {
            turtText.text = "Collect 3 flowers";
            //playerQuests.turtCountText.text = playerQuests.turtCountText.text + "/3";

        }

         if (playerQuests.turtFlowerCount == 3)
        {
            turtStrike.enabled = true;
            turtleQComp = true;
        }
    }
}






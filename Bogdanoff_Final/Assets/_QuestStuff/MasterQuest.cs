using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MasterQuest : MonoBehaviour
{
    PlayerQuests playerQuests;

    public bool chickenQStarted = false;
    public bool chickenQComp = false;

    public bool turtleQStarted = false;
    public static bool turtleQComp = false;
    public Text turtText;
    public Text turtCountText;
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

        }

        if (playerQuests.turtFlowerCount == 3)
        {
            turtStrike.enabled = true;
            turtleQComp = true;
        }
    }
}






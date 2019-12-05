using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MasterQuest : MonoBehaviour
{
    public PlayerQuests playerQuests;

    public bool chickenQStarted = false;
    public bool chickenQComp = false;

    public bool turtDestroyed = false;
    public bool turtleQStarted = false;
    public bool turtleQComp = false;
    public Text turtText;
    public Text turtStrike;
    public GameObject turtle2;

    public bool crowDestroyed = false;
    public bool crowQStarted = false;
    public bool crowQComp = false;
    public Text crowText;
    public Text crowStrike;
    public GameObject crow2;


    void Start()
    {
        turtText.text = "";
        turtStrike.text = "";
        crowText.text = "";
        crowStrike.text = "";
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

         if (turtDestroyed == true)
        {
            turtle2.SetActive(true);

        }
         //CROW STUFF STARTS
        if (crowQStarted == true)
        {
            crowText.text = "Find and bring 5 Feathers to Mr. Crow";
        }

        if (playerQuests.crowFeatherCount == 5)
        {
            crowStrike.enabled = true;
            crowQComp = true;
        }

        if (crowQComp == true)
        {
            crowStrike.text = "__________________________________________________";
        }

        if (crowDestroyed == true)
        {
            crow2.SetActive(true);
        }
    }
}
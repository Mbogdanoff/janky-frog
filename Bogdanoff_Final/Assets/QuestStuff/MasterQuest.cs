using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MasterQuest : MonoBehaviour
{
    public PlayerQuests playerQuests;

    public bool squQStarted = false;
    public bool squQComp = false;
    public bool squDestroyed = false;
    public Text squText;
    public Text squStrike;
    public GameObject squ2;

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

    public AudioClip qComp;


    void Start()
    {
        turtText.text = "";
        turtStrike.text = "";
        crowText.text = "";
        crowStrike.text = "";
       //squText.text = "";
       //squStrike.text = "";
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
            crowText.text = "Find and bring 3 Feathers to Mr. Crow";
        }

        if (playerQuests.crowFeatherCount == 3)
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

        //SQUIRREL STUFF STARTS

        if (squQStarted == true)
        {
            squText.text = "Collect 10 nuts for Mr. Squirrel";
        }

        if (playerQuests.crowFeatherCount == 10)
        {
            squStrike.enabled = true;
            squQComp = true;
        }

        if (squQComp == true)
        {
            squStrike.text = "__________________________________________________";
        }

        if (squDestroyed == true)
        {
            squ2.SetActive(true);
        }
    }
}
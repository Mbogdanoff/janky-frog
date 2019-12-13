using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerQuests : MonoBehaviour
{
    public MasterQuest qManager;
    public DialogueAreaTrigger TurtTrigger;
    public DialogueAreaTriggerCrow CrowTrigger;

    public int turtFlowerCount = 0;
    public Text turtCountText;
    public Text turtText;

    public int crowFeatherCount = 0;
    public Text crowCountText;
    public Text crowtText;

    public int squMushCount = 0;
    public Text squCountText;
    public Text squText;
    bool mushPickup = false;


    void Start()
    {
        turtCountText.text = "";
        crowCountText.text = "";
        squCountText.text = "";
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("TurtlePickup") && qManager.turtleQStarted == true)
        {

            if (qManager.turtleQStarted)
            {
                other.gameObject.SetActive(false);
                turtFlowerCount = turtFlowerCount + 1;
                SetCountTextTurt();
                if (turtFlowerCount == 3)
                {
                    qManager.turtStrike.enabled = true;
                    qManager.turtleQComp = true;
                }
            }
        }

        if (other.gameObject.CompareTag("Turtle"))
        {
            qManager.turtleQStarted = true;
        }

        //Squirrel Stuff
        if (other.gameObject.CompareTag("mushPickup") && qManager.squQStarted == true &! mushPickup)
        {

            if (qManager.squQStarted)
            {
                squMushCount = squMushCount + 1;
                SetCountSquText();
                Destroy(other, 0f);
                other.gameObject.SetActive(false);
                Debug.Log("+1");
                mushPickup = true;
                Invoke("MushSet", .5f);
                if (squMushCount == 10)
                {
                    qManager.squStrike.enabled = true;
                    qManager.squQComp = true;
                }
            }
        }

        if (other.gameObject.CompareTag("Squirrel"))
        {
            qManager.squQStarted = true;
        }
        
    }
    public void SetCountTextTurt()
    {
        turtCountText.text = turtFlowerCount + "/3";
    }

    void Update()
    {
        if (qManager.turtleQComp == true)
        {
           qManager.turtleQStarted = false;
        } 
    }

    public void SetCountSquText()
    {
        squCountText.text = squMushCount + "/10";
    }
    
    void MushSet()
    {
        mushPickup = false;
    }
}

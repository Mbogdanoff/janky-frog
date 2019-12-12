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

    public int squNutCount = 0;
    public Text squCountText;
    public Text squText;


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

      /*  if (other.gameObject.CompareTag("SquPickup") && qManager.squQStarted == true)
        {

            if (qManager.squQStarted)
            {
                other.gameObject.SetActive(false);
                squNutCount = squNutCount + 1;
                SetCountSquText();
                if (squNutCount == 3)
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
        */
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
        squCountText.text = squNutCount + "/10";
    }
}

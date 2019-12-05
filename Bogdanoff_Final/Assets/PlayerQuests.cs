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

    void Start()
    {
        turtCountText.text = "";
        crowCountText.text = "";
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
}

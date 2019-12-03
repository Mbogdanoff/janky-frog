using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerQuests : MonoBehaviour
{
    public MasterQuest qManager;

    public int turtFlowerCount = 0;
    public Text turtCountText;
    public Text turtText;

    void Start()
    {
        turtCountText.text = "";
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("TurtlePickup")  && qManager.turtleQStarted == true )
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
        if (qManager.turtleQStarted == true)
        {
            //turtCountText.text = turtCountText.text;

        } 
    }
}

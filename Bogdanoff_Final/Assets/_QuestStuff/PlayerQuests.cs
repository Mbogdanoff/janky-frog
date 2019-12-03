using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerQuests : MonoBehaviour
{
    MasterQuest qManager;

    public int turtFlowerCount = 0;
    public GameObject turtle;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("TurtlePickup") && qManager.turtleQStarted == true)
        {
            other.gameObject.SetActive(false);
            qManager.turtCountText.text = qManager.turtCountText.text + 1;
            SetCountTextTurt();
            if (qManager.turtCountText.text == 0)
            {

            }
        }

        if (other.gameObject.CompareTag("Turtle"))
        {
            qManager.turtleQStarted = true;
        }
    }
    public void SetCountTextTurt()
    {
        qManager.turtCountText.text = qManager.turtCountText.text + "/3";
    }
}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerQuests : MonoBehaviour
{
    MasterQuest questManage;

    public int turtFlowerCount = 3;
    public Text turtCountText;
    public GameObject TurtleQText;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("TurtlePickup") && questManage.turtleQStarted == true)
        {
            other.gameObject.SetActive(false);
            turtFlowerCount = turtFlowerCount - 1;
            
        }
    }

    void SetCountText()
    {
        turtCountText.text = turtCountText.ToString () + "/3";
        if (turtFlowerCount == 0)
        {

        }
    }
}

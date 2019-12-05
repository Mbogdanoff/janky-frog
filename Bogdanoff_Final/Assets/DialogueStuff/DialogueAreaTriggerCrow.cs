using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueAreaTriggerCrow : MonoBehaviour
{
    public DialogueTrigger trigger1;
    public DialogueManager nextS1;
    public Animator animator1;
    public int crowFeatherCount = 0;
    public PlayerQuests playerQ;
    public MasterQuest qManager;
    public GameObject crow;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            trigger1.Invoke("TriggerDialogue", 0f);
            animator1.SetBool("isOpen", true);
            qManager.crowQStarted = true;
        }

        if (other.gameObject.CompareTag("CrowPickup") && qManager.crowQStarted == true)
        {
            crowFeatherCount = crowFeatherCount + 1;
            SetCountTextCrow();
            if (crowFeatherCount == 5)
            {
                qManager.crowStrike.enabled = true;
                qManager.crowQComp = true;
            }
        }
    }

    void SetCountTextCrow()
    {
        playerQ.crowCountText.text = crowFeatherCount + "/5";
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            nextS1.Invoke("DisplayNextSentence", 0f);
        }

        if (qManager.crowQComp == true)
        {
            qManager.crowDestroyed = true;
            Destroy(crow);
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowTrig2 : MonoBehaviour
{
    public DialogueTrigger trigger;
    public DialogueManager nextS;
    public Animator animator;
    public MasterQuest qManager;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && qManager.crowQComp == true)
        {
            trigger.Invoke("TriggerDialogue", 0f);
            animator.SetBool("isOpen", true);

        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            nextS.Invoke("DisplayNextSentence", 0f);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            nextS.Invoke("EndDialogue", 0f);
        }
    }
}

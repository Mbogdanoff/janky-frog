using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueAreaTrigger : MonoBehaviour
{
    public DialogueTrigger trigger;
    public DialogueManager nextS;
    public Animator animator;
    public MasterQuest qManager;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && qManager.turtleQComp == false)
        {
            trigger.Invoke("TriggerDialogue", 0f);
            animator.SetBool("isOpen", true);
            qManager.turtleQStarted = true;

        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            nextS.Invoke("DisplayNextSentence", 0f);
        }
    }
}

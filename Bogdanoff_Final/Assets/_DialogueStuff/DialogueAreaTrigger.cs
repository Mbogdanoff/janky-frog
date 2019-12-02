using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueAreaTrigger : MonoBehaviour
{
    public DialogueTrigger trigger;
    public DialogueManager nextS;
    public Animator animator;
    public static bool boxIsOpen;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"));
        {
            trigger.Invoke("TriggerDialogue", 0f);
            animator.SetBool("isOpen", true);
            boxIsOpen = true;
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

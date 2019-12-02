using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);

        /* if (DialogueManager.boxIsOpen == false)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        } */
    }
}

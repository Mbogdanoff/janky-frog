using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        if (DialogueManager.isOpen == false)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }
    }
}

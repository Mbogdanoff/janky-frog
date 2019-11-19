using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueAreaTrigger : MonoBehaviour
{
    public DialogueTrigger trigger;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"));
        {
            Invoke("TriggerDialogue", .1f);
            Debug.Log("Test");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueAreaTriggerCrow : MonoBehaviour
{
    public DialogueTrigger trigger1;
    public DialogueManager nextS1;
    public Animator animator1;

    MasterQuest qManager;
    

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"));
        {
            trigger1.Invoke("TriggerDialogue", 0f);
            animator1.SetBool("isOpen", true);
           
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            nextS1.Invoke("DisplayNextSentence", 0f);
        }
    }
}
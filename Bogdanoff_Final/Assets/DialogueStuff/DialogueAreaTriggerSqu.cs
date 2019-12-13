using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueAreaTriggerSqu : MonoBehaviour
{
    public DialogueTrigger trigger;
    public DialogueManager nextS;
    public Animator animator;
    public MasterQuest qManager;
    private Object self;
    public GameObject squirrel;

    public AudioClip questGet;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && qManager.squQComp == false)
        {
            trigger.Invoke("TriggerDialogue", 0f);
            animator.SetBool("isOpen", true);
            qManager.squQStarted = true;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            nextS.Invoke("DisplayNextSentence", 0f);
        }

        if (qManager.squQComp == true)
        {
            qManager.squDestroyed = true;
            Destroy(squirrel);
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

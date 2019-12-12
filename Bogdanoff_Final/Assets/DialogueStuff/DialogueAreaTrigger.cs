using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DialogueAreaTrigger : MonoBehaviour
{
    public DialogueTrigger trigger;
    public DialogueManager nextS;
    public Animator animator;
    public MasterQuest qManager;
    private Object self;
    public GameObject turtle;

    public AudioClip questGet;

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

        if (qManager.turtleQComp == true)
        {
            qManager.turtDestroyed = true;
            Destroy(turtle);

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

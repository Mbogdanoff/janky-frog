using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    Queue<string> sentences;

    public Text nameText;
    public Text dialogueText;

    public Animator animator;

    public bool boxIsOpen = false;

    public bool exitArea = true;

    void Start() {

        sentences = new Queue<string>();
    }

   public void StartDialogue (Dialogue dialogue)
    {
        if (boxIsOpen == false)
        {
            boxIsOpen = true;
            animator.SetBool("isOpen", true);

            nameText.text = dialogue.name;

            sentences.Clear();

            foreach (string sentence in dialogue.sentences)
            {
                sentences.Enqueue(sentence);
            }

            DisplayNextSentence();
        }
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }


    void EndDialogue()
    {
        animator.SetBool("isOpen", false);
        boxIsOpen = false;
    }
}

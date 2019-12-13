using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    public AudioClip ribbit;
    public AudioSource source;
    bool rib;
    bool isMlem = false;
    public AudioClip mlem;
    public GameObject tutPop;
    public GameObject beginningTutPop;
    public GameObject endPop;
    public MasterQuest qManager;

    void Awake()
    {
        beginningTutPop.SetActive(true);
        Invoke("tutPopSet", 5f);
        endPop.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }

        if (Input.GetKeyDown(KeyCode.G) && qManager.youWin)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (Input.GetKey("r") &&! rib)
        {
            source.PlayOneShot(ribbit);
            rib = true;
            Invoke("isRib", 0.75f);
        }
        
        if (Input.GetMouseButton(0) && !isMlem)
        {
            source.PlayOneShot(mlem);
            isMlem = true;
            Invoke("MlemShot", .25f);
        }

        if (Input.GetKey("tab"))
        {
            tutPop.SetActive(true);
        }
        else
        {
            tutPop.SetActive(false);
        }

        if (qManager.youWin)
        {
            endPop.SetActive(true);
        }
        else
        {
            endPop.SetActive(false);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Floor"))
        {
            transform.position = new Vector3(0, 5, 0);
        }
    }

    void isRib()
    {
        rib = false;
    }

    void MlemShot()
    {
        isMlem = false;
    }

    void tutPopSet()
    {
        beginningTutPop.SetActive(false);
    }

}

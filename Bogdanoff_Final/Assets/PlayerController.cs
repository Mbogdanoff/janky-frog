using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public AudioClip ribbit;
    public AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }

        if (Input.GetKey("R"))
        {
            source.PlayOneShot(ribbit);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Floor"))
        {
            transform.position = new Vector3(0, 5, 0);
        }
    }
}

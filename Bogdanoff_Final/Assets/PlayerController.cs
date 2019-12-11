using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
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

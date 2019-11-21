using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hookDetector : MonoBehaviour
{
    public GameObject player;


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Hookable")
        {
            player.GetComponent<grapplingHook>().hooked = true;
            player.GetComponent<grapplingHook>().hookedObj = other.gameObject;
        }

        if(other.tag == "Sticky")
        {
            player.GetComponent<grapplingHook>().objHooked = other.gameObject;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hookDetector : MonoBehaviour
{
    public GameObject player;
    grapplingHook grappleScript;
    private GameObject hook;

    void OnTriggerEnter(Collider other)
    {
        

        if (other.tag == "Hookable")
        {
            player.GetComponent<grapplingHook>().hooked = true;
            player.GetComponent<grapplingHook>().hookedObj = other.gameObject;
        }

        if (other.tag == "Sticky")
        {
            var otherTransform = other.GetComponent<Transform>();
            //player.GetComponent<grapplingHook>().objHooked = other.gameObject;
            otherTransform = this.transform;
            grappleScript = GameObject.Find("Hook").GetComponent<grapplingHook>();
            grappleScript.ReturnHook();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        grappleScript.ReturnHook();
    }


}

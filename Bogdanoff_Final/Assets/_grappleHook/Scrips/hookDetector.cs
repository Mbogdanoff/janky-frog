using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hookDetector : MonoBehaviour
{
    public GameObject player;
    grapplingHook grappleScript;
    private GameObject hook;
    public bool normalHit;

    void OnTriggerEnter(Collider other)
    {
        

        if (other.tag == "Hookable")
        {
            player.GetComponent<grapplingHook>().hooked = true;
            player.GetComponent<grapplingHook>().hookedObj = other.gameObject;
        }

        if (other.tag == "Sticky") //pullable object tag
        {
            var otherTransform = other.GetComponent<Transform>();
            //player.GetComponent<grapplingHook>().objHooked = other.gameObject;
            otherTransform = this.transform;
            grappleScript = GameObject.Find("Hook").GetComponent<grapplingHook>();
            //grappleScript.Invoke("ReturnHook", 0f);
        }

        if (other.gameObject.CompareTag("Untagged")) //normal objects
        {
           // grappleScript.Invoke("ReturnHook", 0f);
        }
    }
}

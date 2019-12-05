using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hookDetector : MonoBehaviour
{
    public GameObject player;
    grapplingHook grappleScript;
    private GameObject hook;
    public bool normalHit;
    public float stickTime = 3f;

    bool sticked = false;

    void OnTriggerEnter(Collider other)
    {
        

        if (other.tag == "Hookable")
        {
            player.GetComponent<grapplingHook>().hooked = true;
            player.GetComponent<grapplingHook>().hookedObj = other.gameObject;
        }

        if (other.tag == "Sticky") //pullable object tag
        {
            sticked = true;

            var otherTransform = other.GetComponent<Transform>();

            player.GetComponent<grapplingHook>().objHooked = other.gameObject;
            otherTransform = this.transform;

            FindObjectOfType<grapplingHook>().ReturnHook();

            //other.gameObject.GetComponent<Rigidbody>().useGravity = false;
        }

        if (other.gameObject.CompareTag("Untagged")) //normal objects
        {
            FindObjectOfType<grapplingHook>().ReturnHook();
        }
    }

    void Update()
    {

    }
}

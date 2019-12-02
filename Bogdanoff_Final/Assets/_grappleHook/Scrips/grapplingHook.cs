using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grapplingHook : MonoBehaviour
{
    Transform target;
    public GameObject objHooked;  //object you hook to bring to you


    public GameObject camera;

    public GameObject hook;
    public GameObject hookHolder;

    public float hookTravelSpeed;
    public float playerTravelSpeed;

    public static bool fired;
    public bool hooked;
    public GameObject hookedObj;

    public float maxDistance;
    private float currentDistance;

    public float x = 0.2f;
    public float y = 0.2f;
    public float z = 0.2f;

    

    void Update()
    {
        //firing the hook
        if(Input.GetMouseButton(0) && fired == false)
            fired = true;

        if (fired)
        {
            LineRenderer rope = hook.GetComponent<LineRenderer>();
            rope.SetVertexCount(2);
            rope.SetPosition(0, hookHolder.transform.position);
            rope.SetPosition(1, hook.transform.position);
        }

        if(fired == true && hooked == false)
        {
            hook.transform.Translate(Vector3.forward * Time.deltaTime * hookTravelSpeed);
            currentDistance = Vector3.Distance(transform.position, hook.transform.position);

            if (currentDistance >= maxDistance)
                ReturnHook();

        }

        if(hooked == true && fired == true)
        {
            hook.transform.parent = hookedObj.transform;
            transform.position = Vector3.MoveTowards(transform.position, hook.transform.position, Time.deltaTime * playerTravelSpeed);
            float distanceToHook = Vector3.Distance(transform.position, hook.transform.position);


            this.GetComponent<Rigidbody>().useGravity = false;

            if (distanceToHook < 1)
                ReturnHook();

        } else {
            hook.transform.parent = hookHolder.transform;
            this.GetComponent<Rigidbody>().useGravity = true;
            hook.transform.localScale = new Vector3(x, y, z);
        }

        if (Input.GetMouseButton(1) && fired == true)
            ReturnHook();

    }

    public void ReturnHook()
    {
        hook.transform.rotation = hookHolder.transform.rotation;
        hook.transform.position = hookHolder.transform.position;
        hook.transform.localScale = new Vector3(x, y, z);
        fired = false;
        hooked = false;

        LineRenderer rope = hook.GetComponent<LineRenderer>();
        rope.SetVertexCount(0);
    }

}

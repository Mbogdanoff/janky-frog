using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tonguePull : MonoBehaviour
{
   public float speed = 50.0f;

    // The target position.
    private Transform target;
    public GameObject tongue;
    bool stuck = false;

    void Awake()
    {
        target = tongue.transform;
    }

    void Update()
    {
        if (stuck == true)
        {
            // Move our position a step closer to the target.
            float step = speed * Time.deltaTime; // calculate distance to move
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Hook"))
        {
            stuck = true;
        }
        if (other.gameObject.CompareTag("Holder"))
        {
            stuck = false;
        }
    }

    //public collider reference that dissables box collider (that isn't a trigger) before it hits player (so when it gets to a certain point)
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Rigidbody))]
public class GravityBody : MonoBehaviour
{
    public GravityAttractor attractor;
    private Transform myTransform;

    void Start()
    {
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;

        myTransform = transform;
    }

    void Update()
    {
        if (attractor) attractor.Attract(myTransform);
    }
}
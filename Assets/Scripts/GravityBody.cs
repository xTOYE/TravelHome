﻿using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class GravityBody : MonoBehaviour
{

    GravityAttractor planet;
    Rigidbody rigidbody;

    //disabling all the nesasary rigidbody components to allow it to move on its own
    void Awake()
    {
        planet = GameObject.FindGameObjectWithTag("Planet").GetComponent<GravityAttractor>();
        rigidbody = GetComponent<Rigidbody>();//finds the rigidbody
        rigidbody.useGravity = false;//disables gravity
        rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
    }

    void FixedUpdate()
    {
        planet.Attract(rigidbody);
    }
}
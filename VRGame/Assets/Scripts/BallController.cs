﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float maximumSpeed = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float speed = Vector3.Magnitude(rigidbody.velocity);  // test current object speed

        if (speed > maximumSpeed)

        {
            float brakeSpeed = speed - maximumSpeed;  // calculate the speed decrease

            Vector3 normalisedVelocity = rigidbody.velocity.normalized;
            Vector3 brakeVelocity = normalisedVelocity * brakeSpeed;  // make the brake Vector3 value

            rigidbody.AddForce(-brakeVelocity);  // apply opposing brake force
        }
    }
}

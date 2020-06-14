﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce;
    public float sideWaysForce;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void FixedUpdate()
    {
        //move foward automatically
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        
        if (Input.GetKey("d"))
        {
            rb.AddForce(sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        //if (Input.GetKey("w"))
        //{
        //    rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        //}
        //if (Input.GetKey("s"))
        //{
        //    rb.AddForce(0, 0, -forwardForce * Time.deltaTime);
        //}

        if(rb.position.y < 0f)
        {
            FindObjectOfType<GameManagerEngine>().EndGame();
        }
    }
}

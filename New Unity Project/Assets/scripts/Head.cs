﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head : MonoBehaviour
{
    public Rigidbody2D rb2d;
   private float force;
    public Transform normall;
    public static bool isdead = false;
    private float countdown=2f;
    private bool startedcount = false;

     
    void Update()
    {
        if (Body.HeadIsattatched)
        {
            force = 10000f;

        }
        else force = 500f;
        normall.position = transform.position;
        if (Input.GetKey("d"))
        {
            rb2d.AddForce(normall.right.normalized * force * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            rb2d.AddForce(-normall.right.normalized * force * Time.deltaTime);

        }
        if (startedcount== false)
 
        if (isdead)
        {
                tongue.isattatched = false ;
                countdown -= Time.deltaTime;
                if (countdown <= 0f && !startedcount) 
                {
                    startedcount = false ;
                    isdead = false;
                }


        }
        

    }
}

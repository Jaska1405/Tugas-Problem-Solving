﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    //private Rigidbody2D rigidbody2D;
    //public float xForce;
    //public float yForce;

    //void Start()
    //{
        //rigidbody2D = GetComponent<Rigidbody2D>();
    //}
    ///void PushBall()
    //{
        //float arahRandom = Random.Range(-10, 10);
        //if (arahRandom < 1.0f)
        //{
            //rigidbody2D.AddForce(new Vector2(-xForce, yForce));
        //}
        //else
        //{
            //rigidbody2D.AddForce(new Vector2(xForce, -yForce));
        //}
        //Debug.Log(arahRandom);

    public float moveSpeed = 10;
    
    // Update is called once per frame
    void Update()
    {
        //PushBall();
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = Vector2.MoveTowards(transform.position, mousePosition, moveSpeed * Time.deltaTime);

    }
}

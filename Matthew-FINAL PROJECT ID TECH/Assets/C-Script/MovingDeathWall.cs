﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingDeathWall : MonoBehaviour
{
    Vector3 moveVector = new Vector3(0, 1, 0);
    public int speed = 5;
    bool facingFoward = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(moveVector * speed * Time.deltaTime);
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        Vector3 rot = new Vector3(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + 180, 
            transform.rotation.eulerAngles.z);
        if (transform.position.x <= -3.0f && facingFoward == false)
        {
            transform.rotation = Quaternion.Euler(rot);
            facingFoward = true;
        }
        if (transform.position.x >= 3.0f && facingFoward == true)
        {
            transform.rotation = Quaternion.Euler(rot);
            facingFoward = false;
        }
    }
}
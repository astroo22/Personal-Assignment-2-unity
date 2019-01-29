﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockInteractions : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    // Start is called before the first frame update
    void Start()
    {

        rigidBody = this.GetComponent<Rigidbody2D>();
        rigidBody.gravityScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rigidBody.gravityScale = 1.0f;
            transform.parent = null;
        }
    }
}
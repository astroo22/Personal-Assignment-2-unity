﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openL : MonoBehaviour
{
    bool open = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !open)
        {
            transform.Rotate(Vector3.forward * -90);
            open = true;
        }
        else if(Input.GetKeyDown(KeyCode.Space) && open)
        {
            transform.Rotate(Vector3.forward * 90);
            open = false;
        }
        
    }
}

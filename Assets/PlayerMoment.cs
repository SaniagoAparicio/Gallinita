﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoment : MonoBehaviour
{

    public float MovementSpeed;
    public float RotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            //transform.position += new Vector3(0, 0, MovementSpeed);
            transform.Translate(0, 0, MovementSpeed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            //transform.position += new Vector3(0, 0, MovementSpeed);
            transform.Translate(0, 0, -MovementSpeed);
        }

        if(Input.GetKey (KeyCode.A))
        {
            transform.Rotate(0, RotationSpeed, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, -RotationSpeed, 0);
        }
    }
}

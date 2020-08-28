using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeController : MonoBehaviour
{
    public WheelJoint2D backWheel;

    JointMotor2D motor;
    public float forwardSpeed;
    public float reverseSpeed;

    public float forwardTorque;
    public float reverseTorque;

    public bool traction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") < 0)
        {
            Debug.Log("Backward"); 
            if (traction)
            {
                motor.motorSpeed = reverseSpeed;
                motor.maxMotorTorque = reverseTorque;
                backWheel.motor = motor;
            }
        }
        else if (Input.GetAxis("Horizontal") > 0)
        {
            Debug.Log("Forward");
            if (traction)
            {
                motor.motorSpeed = forwardSpeed * -1;
                motor.maxMotorTorque = forwardTorque;
                backWheel.motor = motor;
            }
        }
        else
        {
            backWheel.useMotor = false;
        }
        
    }
}

using UnityEngine;
using System.Collections;

public class HingeScript : MonoBehaviour {

    HingeJoint2D hinge;
    JointMotor2D motor;

    void Start()
    {
        hinge = GetComponent<HingeJoint2D>();
        motor = hinge.motor;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            motor.motorSpeed = 150;
            hinge.motor = motor;
            hinge.useMotor = true;
        }
    }
}

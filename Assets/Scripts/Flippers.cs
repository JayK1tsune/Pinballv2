using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flippers : MonoBehaviour
{
    public float restPosition = 0f;
    public float pressedPosision = 45f;
    public float hitPower = 10000f;
    public float damper = 150f;
    HingeJoint hinge;

    public string inputName;

    private void Start()
    {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;

    }
    private void Update()
    {
        JointSpring spring = new JointSpring();
        spring.spring = hitPower;
        spring.damper = damper;

        if(Input.GetAxis(inputName) == 1)
        {
            spring.targetPosition = pressedPosision;
        }
        else
        {
            spring.targetPosition = restPosition;
        }
        hinge.spring = spring;
        hinge.useLimits = true;
    }
}

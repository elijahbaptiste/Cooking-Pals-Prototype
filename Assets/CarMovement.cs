using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CarMovement : MonoBehaviour
{
    public Rigidbody rb3D;
    public GameObject EmptyPointReference;

    [SerializeField] WheelCollider FrontLeft;
    [SerializeField] WheelCollider FrontRight;
    [SerializeField] WheelCollider BackLeft;
    [SerializeField] WheelCollider BackRight;

    public float acceleration;
    public float breakForce;
    private float currAcceleration = 0f;
    private float currBreakForce = 0f;
    public float MaxTurnAngle;
    public float currTurnAngle;

    // Start is called before the first frame update
    void Start()
    {
        rb3D = GetComponent<Rigidbody>();

    }

    void Update()
    {
        var direction = new Vector3(EmptyPointReference.transform.position.x - rb3D.position.x, 0, EmptyPointReference.transform.position.z - rb3D.position.z);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //rb3D.AddTorque(rb3D.transform.up * Input.GetAxis("Horizontal") * 20, ForceMode.Acceleration);
        //rb3D.AddForce(rb3D.transform.forward * 35 * Input.GetAxis("Vertical"), ForceMode.Force);
        currAcceleration = acceleration * Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.Space))
            currBreakForce = breakForce;
        else
            currBreakForce = 0f;
        Debug.Log("Current Break Force: " + currBreakForce);

        FrontLeft.motorTorque = currAcceleration;
        FrontRight.motorTorque = currAcceleration;

        FrontLeft.brakeTorque = currBreakForce;
        FrontRight.brakeTorque = currBreakForce;
        BackLeft.motorTorque = currBreakForce;
        BackRight.motorTorque = currBreakForce;

        currTurnAngle = MaxTurnAngle * Input.GetAxis("Horizontal");
        Debug.Log("Current turn angle: "+ currTurnAngle);
        FrontLeft.steerAngle = currTurnAngle;
        FrontRight.steerAngle = currTurnAngle;

    }
}

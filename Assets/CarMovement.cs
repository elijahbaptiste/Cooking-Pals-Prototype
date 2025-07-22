using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public Rigidbody rb3D;
    public GameObject EmptyPointReference;

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
        if (Input.GetKey(KeyCode.W))
        {
            rb3D.AddForce(rb3D.transform.forward * 50,ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb3D.AddTorque(0, 10, 0, ForceMode.Acceleration);
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            rb3D.AddForce(rb3D.transform.forward * -50, ForceMode.Force);
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            rb3D.AddTorque(0, -10, 0, ForceMode.Acceleration);
        }

    }
}

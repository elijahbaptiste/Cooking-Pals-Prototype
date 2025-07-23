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

        rb3D.AddTorque(rb3D.transform.up * Input.GetAxis("Horizontal") * 20, ForceMode.Acceleration);
        rb3D.AddForce(rb3D.transform.forward * 35 * Input.GetAxis("Vertical"), ForceMode.Force);

    }
}

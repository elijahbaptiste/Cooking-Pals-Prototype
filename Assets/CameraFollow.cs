using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public GameObject car;
    public GameObject FacingPoint;
    public Camera PlayerCam;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //PlayerCam.transform.position = car.transform.position + new Vector3(-12,10,10);
        PlayerCam.transform.LookAt(FacingPoint.transform);
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyPointFollow : MonoBehaviour
{
    public GameObject car;
    public GameObject FacingPoint;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       FacingPoint.transform.position = car.transform.position + new Vector3(5,0,0);
    }
}

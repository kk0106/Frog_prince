using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plan : MonoBehaviour
{
    public GameObject axis;
    private float y;
    private float z;
    public float rotateSpeed;
    // Start is called before the first frame update
    void Start()
    {
        z = this.gameObject.transform.rotation.z;
        y= this.gameObject.transform.rotation.y;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.eulerAngles = new Vector3(0,90,z);
        this.transform.RotateAround(axis.transform.position,new Vector3(0,0,-1),rotateSpeed);
    }
}

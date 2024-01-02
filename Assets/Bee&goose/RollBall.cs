using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollBall : MonoBehaviour
{
    private Rigidbody rb;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        rb=gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       // rb.velocity = Vector3.left*speed;

       rb.AddForce(Vector3.left*speed);
       
    }
}

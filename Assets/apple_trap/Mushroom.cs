using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom : MonoBehaviour
{
    public float jumpspeed=3f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
            rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            rb.AddForce(Vector3.up * jumpspeed);
        }
    }
}

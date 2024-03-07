using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wolf_move : MonoBehaviour
{  
    private Rigidbody rb;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
        speed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        this.rb.velocity = Vector3.right*speed;

        if (StartTrigger.startValue == 2)
        {
            speed = 1;
        }
        if (StartTrigger.startValue == 4)
        {
            speed = 2;
        }
        if (StartTrigger.startValue == 3)
        {
            speed = 0;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;

    public float time;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (this.gameObject.activeInHierarchy)
        {
            time += Time.deltaTime;
        }

        if (time > 1)
        {
            rb.velocity = Vector3.left * speed;
        }

        if (time > 1.5)
        {
            time = 0;
        }
    }
}

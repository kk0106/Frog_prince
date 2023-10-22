using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rbControl : MonoBehaviour
{
    public GameObject trigger;
    public float speed;
    Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!trigger.activeInHierarchy)
        {
            ani.SetBool("run", true);
            transform.position += transform.right * speed;

        }
    }
}

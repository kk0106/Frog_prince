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
        if(rbcomic.A==1)
        {
            ani.SetBool("look", true);
           
        }
        if (rbcomic.A ==2)
        {
            ani.SetBool("look", false);

        }

        if (!trigger.activeInHierarchy)
        {
            ani.SetBool("run", true);

            Invoke("run", 0.3f);
        }
    }

    private void run()
    {
        transform.position += transform.right * speed;
    }
}

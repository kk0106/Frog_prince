using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rbControl : MonoBehaviour
{
   
    public float speed;
    Animator ani;
    public float time;
    public int a;
    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        ani = GetComponent<Animator>();

        speed = 0;

        a = 0;
    }

    // Update is called once per frame
    void Update()
    {

        ani.SetBool("run", true);

        if (a==1)
        {
            time -= Time.deltaTime;
        }

        if(time < 0)
        {
            speed = 0.05f;
        }

        transform.position += transform.right * speed;
    }

  


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
          
            a = 1;
        }
    }
}

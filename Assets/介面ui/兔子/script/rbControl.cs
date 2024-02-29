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
        


        if (a==1)
        {
            time -= Time.deltaTime;
            ani.SetBool("run", true);
        }
        
        if(time < 0.048)
        {
            speed = 0.05f;
        }

        transform.position += transform.right * speed;
    }




    public void A()
    {
        a =1;
    }
}

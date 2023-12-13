using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setAni : MonoBehaviour
{
    private Animator ani;
    public float time;
   
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
      if(Attack.anifloat==1)
        {
           time-=Time.deltaTime;
            ani.speed = 1;
        }


      if(time<4)
        {
            ani.SetBool("up", true);

           
        }
      if(time<2.5f)
        {
            if (Attack.a == 1)
            {
                Attack.Mark = 1;
            }
        }
      if(time<2)
        {
            ani.SetBool("attack", true);
        }
        if (time < 0)
        {
            ani.SetBool("normal", true);

          
        }
        if (time < -0.3)
        {
            ani.speed = 0;
        }
       
        if (time < -2)
        {
         
            Attack.anifloat = 2;
            time = 5;
        }
      
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "ice")
        {
            other.gameObject.SetActive(false);
        }
    }
}

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
            if (Attack.a == 2)
            {
                Attack.Mark = 2;
            }
            if (Attack.a == 3)
            {
                Attack.Mark = 3;
            }
            if (Attack.a == 4)
            {
                Attack.Mark = 4;
            }
            if (Attack.a == 5)
            {
                Attack.Mark = 5;
            }
            if (Attack.a == 6)
            {
                Attack.Mark = 6;
            }
            if (Attack.b == 1)
            {
                Attack.Mark = 7;
            }
            if (Attack.b == 2)
            {
                Attack.Mark = 8;
            }
            if (Attack.b == 3)
            {
                Attack.Mark = 9;
            }
            if (Attack.b == 4)
            {
                Attack.Mark = 10;
            }
            if (Attack.b == 5)
            {
                Attack.Mark = 11;
            }
            if (Attack.b == 6)
            {
                Attack.Mark = 12;
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

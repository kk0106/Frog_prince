using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setAni : MonoBehaviour
{
    private Animator ani;
    public float time;
    public static int Attacked;
   
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
      if(attack1.SetAni==1)
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
            if (attack1.WhichAttack==1)
            {
                attack1.Mark = 1;
            }
            if (attack1.WhichAttack == 2)
            {
                attack1.Mark = 2;
            }
            if (attack1.WhichAttack == 3)
            {
                attack1.Mark = 3;
            }
            if (attack1.WhichAttack == 4)
            {
                attack1.Mark = 4;
            }
         
        }
      if(time<2)
        {
            ani.SetBool("attack", true);
           
        }
        if (time < 1.8)
        {
            Attacked = 1;
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

            attack1.SetAni = 2;
            attack1.WhichAttack = 0;
            time = 5;
            Attacked = 0;
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setAni6 : MonoBehaviour
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
        if (attack6.SetAni == 1)
        {
            time -= Time.deltaTime;
            ani.speed = 1;
        }


        if (time < 4)
        {
            ani.SetBool("up", true);
        }

        if (time < 3)
        {
            ani.SetBool("attack", true);

        }
        if (time < 2.9)
        {
            Attacked = 1;
        }
        if (time < 2.7)
        {
          
                ani.SetBool("normal", true);
                ani.SetBool("attack", false);
                ani.SetBool("up", false);  
        }
        if (time < 2.6)
        {
            Attacked = 0;
            this.gameObject.SetActive(false);
        }

       
        if (time < 2.55)
        {

            attack6.SetAni = 3;
            attack6.WhichAttack = 0;
            time = 4.1f;

            Debug.Log(attack6.SetAni);
        }

    }
}

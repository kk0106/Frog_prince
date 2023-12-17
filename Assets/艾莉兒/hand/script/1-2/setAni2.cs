using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setAni2 : MonoBehaviour
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
        if (attack2.SetAni == 1)
        {
            time -= Time.deltaTime;
            ani.speed = 1;
        }


        if (time < 4)
        {
            ani.SetBool("up", true);


        }

        if (time < 2)
        {
            ani.SetBool("attack", true);

        }
        if (time < 1.8)
        {
            Attacked = 1;
        }
        if (time < 1.6)
        {
            if (attack2.WhichAttack != 5)
            {
                ani.SetBool("normal", true);
                ani.SetBool("attack", false);
                ani.SetBool("up", false);
            }

        }
        if (time < 1.4)
        {
            Attacked = 0;
        }

        if (time < 0.7)
        {
            if (attack2.WhichAttack == 5)
            {
                ani.SetBool("normal", true);
                ani.SetBool("attack", false);
                ani.SetBool("up", false);
            }
        }
        if (time < 0.6)
        {

            attack2.SetAni = 3;
            attack2.WhichAttack = 0;
            time = 4.1f;

            Debug.Log(attack2.SetAni);
        }
    }
    }

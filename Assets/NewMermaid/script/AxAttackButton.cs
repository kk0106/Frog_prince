using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxAttackButton : MonoBehaviour
{

    [Header("ax")] 
    public GameObject ax;
    public GameObject ax2;
    private Rigidbody rb;
    private Rigidbody rb2;
    public float speed;
    private Animator ani;
    private Animator ani2;
    // Start is called before the first frame update
    void Start()
    {
        ax.SetActive(false);
        ax2.SetActive(false);

        rb = ax.GetComponent<Rigidbody>();
        rb2 = ax2.GetComponent<Rigidbody>();

        ani = ax.GetComponent<Animator>();
        ani2 = ax2.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ax.activeInHierarchy&&BossHp.WhatLevelNow==1)
        {
           rb.velocity = Vector3.forward*speed;
        }


        if (ax2.activeInHierarchy&&BossHp.WhatLevelNow==2)
        {
            rb2.velocity = Vector3.forward * speed;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            if(BossHp.WhatLevelNow==1)
            {
                ax.SetActive(true);
            }
            if (BossHp.WhatLevelNow == 2)
            {
                ax.SetActive(true);
            }
           
        }
    }
}

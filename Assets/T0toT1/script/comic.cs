using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class comic : MonoBehaviour
{
    public float time;
    public static int a=0;

    public GameObject a2;

    public GameObject b1;
    public GameObject b2;
    public GameObject b3;
    public GameObject b4;
    public GameObject b5;
    public GameObject b6;


    [Header ("3")]    
    public GameObject c1;
    public GameObject c2;

    public GameObject d1;    
    public GameObject d2;
    public GameObject d3;
    public GameObject d4;
    public GameObject d5;
    public GameObject d6;
    public GameObject d7;
    public GameObject d8;
    public GameObject d9;
    public GameObject d10;
    public GameObject d11;
    public GameObject d12;

    public GameObject e1;

    public GameObject button;

    void Start()
    {
       
     

      
        a2.SetActive(false);

        b1.SetActive(false);
        b2.SetActive(false);
        b3.SetActive(false);
        b4.SetActive(false);
        b5.SetActive(false);
        b6.SetActive(false);

        c1.SetActive(false);
        c2.SetActive(false);

        d1.SetActive(false);
        d2.SetActive(false);
        d3.SetActive(false);
        d4.SetActive(false);
        d5.SetActive(false);
        d6.SetActive(false);
        d7.SetActive(false);
        d8.SetActive(false);
        d9.SetActive(false);
        d10.SetActive(false);
        d11.SetActive(false);
        d12.SetActive(false);

        e1.SetActive(false);

        button.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        
        if(time > 1)
        {
            a2.SetActive (true);
        }

        if(time > 1.5)
        {
            b1.SetActive (true);
            
        }

        if(time > 3)
        {
            b2.SetActive(true);
        }
        if (time > 3.5)
        {
            b3.SetActive(true);
        }
        if (time > 5.5)
        {
            b4.SetActive(true);
        }
        if (time > 6.5)
        {
            b5.SetActive(true);
        }
        if (time > 7)
        {
            b6.SetActive(true);
        }

        if (time > 8.5)
        {
           c1.SetActive (true);

        }
        if (time > 9)
        {
           c2.SetActive (true);

        }
        if (time > 9.5)
        {
           d1.SetActive (true);

        }
        if (time > 10)
        {
            d2.SetActive(true);

        }
        if (time > 11.5)
        {
            d3.SetActive(true);

        }
        if (time > 12)
        {
            d4.SetActive(true);

        }

        if (time > 13)
        {
            d5.SetActive(true);
        }
        if (time > 13.5)
        {
            d6.SetActive(true);
        }
        if (time > 14.5)
        {
            d7.SetActive(true);

        }

        if (time > 15.5)
        {
            d8.SetActive(true);
        }
        if (time > 16)
        {
            d9.SetActive(true);
        }
        if (time > 16.5)
        {
            d10.SetActive(true);
        }
        if(time > 17.5)
        {
            d11.SetActive(true);
        }
        if (time > 20.5)
        {
            d12.SetActive(true);
        }
        if (time > 21.5)
        {
            e1.SetActive(true);
        }
        if(time > 22.5)
        {
            button.SetActive(true);
        }

        
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UI;

public class comic : MonoBehaviour
{
    public float time;
    public static int a=0;

    [Header("1")]
   // public GameObject a1;
    public GameObject a2;

   // private Vector3 pos1;
   
    

    [Header("2")]
    public GameObject b1;
    public GameObject b2;
    public GameObject b3;
    public GameObject b4;
    public GameObject b5;
    public GameObject b6;


    [Header ("3")]    
    public GameObject c1;
    public GameObject c2;

    

    [Header("4")]
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

    [Header("5")]
    public GameObject e1;
    public GameObject e2;
    public GameObject e3;
    public GameObject e4;
    public GameObject e5;
    public GameObject e6;

    [Header("6")]
    public GameObject f;
    public GameObject g;
    // Start is called before the first frame update
    void Start()
    {
       
     

       // a1.SetActive(false);
        a2.SetActive(false);



        

       // b1.SetActive(false);
        b2.SetActive(false);
        b3.SetActive(false);
        b4.SetActive(false);
        b5.SetActive(false);
        b6.SetActive(false);

        //c1.SetActive(false);
       // c2.SetActive(false);

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
        e2.SetActive(false);
        e3.SetActive(false);
        e4.SetActive(false);
        e5.SetActive(false);
        e6.SetActive(false);
        f.SetActive(false);
       
        g.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > 1)
        {
            a = 1;
        }
        if(time > 2)
        {
            a2.SetActive (true);
        }

        if(time > 3)
        {
            b1.SetActive (true);
            
        }

        if (time > 4)
        {
            a = 2;
        }

       

        if(time > 6)
        {
            b2.SetActive(true);
        }
        if (time > 7)
        {
            b3.SetActive(true);
        }
        if (time > 8)
        {
            b4.SetActive(true);
        }
        if (time > 8.5)
        {
            b5.SetActive(true);
        }
        if (time > 9)
        {
            b6.SetActive(true);
        }

        if (time > 10)
        {
            a=3;

        }
        if (time > 11)
        {
            a = 4;

        }
        if (time > 12)
        {
           d1.SetActive (true);

        }
        if (time > 13)
        {
            d2.SetActive(true);

        }
        if (time > 13.9)
        {
            d3.SetActive(true);

        }
        if (time > 14.7)
        {
            d4.SetActive(true);

        }
        if (time > 15.4)
        {
            d5.SetActive(true);

        }
        if (time > 16)
        {
            d6.SetActive(true);

        }
        if (time > 16.5)
        {
            d7.SetActive(true);

        }
        if (time > 16.9)
        {
            d8.SetActive(true);

        }
        if (time > 17.3)
        {
            d9.SetActive(true);

        }
        if (time > 17.7)
        {
            d10.SetActive(true);

        }
        if (time > 18.1)
        {
            d11.SetActive(true);

        }
        if (time > 18.5)
        {
            d12.SetActive(true);

        }
        if (time > 19.5)
        {
            e1.SetActive(true);

        }
        if (time > 20.5)
        {
            e2.SetActive(true);

        }
        if (time > 21.5)
        {
            e3.SetActive(true);

        }
        if (time > 22.5)
        {
           e4.SetActive(true);

        }
        if (time > 23.5)
        {
            e5.SetActive(true);

        }
        if (time > 24.5)
        {
            e6.SetActive(true);

        }
        if (time > 25.5)
        {
            f.SetActive(true);
            a = 5;

        }

        if (time > 26.5)
        {
            g.SetActive(true);
           

        }
    }
}

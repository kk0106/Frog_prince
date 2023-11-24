using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ani : MonoBehaviour
{
    

    [Header("timer & Another")]
    public GameObject bk;
    public float timer;


    [Header("animation")]
    public GameObject a;
    public GameObject b;
    public GameObject c;
    public GameObject d;
    public GameObject e;
    public GameObject f;
    public GameObject g;
    public GameObject h;
    public GameObject i;
    public GameObject j;
    public GameObject k;
    public GameObject l;
    // Start is called before the first frame update
    void Start()
    {
        a.SetActive(false);
        b.SetActive(false);
        c.SetActive(false);
        d.SetActive(false);
        e.SetActive(false);
        f.SetActive(false);
        g.SetActive(false);    
        h.SetActive(false);
        i.SetActive(false);
        j.SetActive(false);
        k.SetActive(false);
        l.SetActive(false);

           
    }

    // Update is called once per frame
    void Update()
    {
        if (bk.activeInHierarchy)
        {
            timer -= Time.deltaTime;
        }


        if(timer<5.5)
        {
            a.SetActive(true);
        }
        if (timer < 5)
        {
            b.SetActive(true);
        }
        if(timer < 3) 
        {
            
            c.SetActive(true) ;
        }
        if (timer < 2)
        {
            d.SetActive(true);
        }
        if( timer < 0)
        {
            e.SetActive(true);
        }
        if (timer < -1f)
        {
            f.SetActive(true);
        }
        if (timer < -2.5f)
        {
            g.SetActive(true);
        }
        if(timer<-4)
        {
            h.SetActive(true);
        }
        if (timer < -4.5)
        {
            i.SetActive (true);
        }
        if (timer < -5.5)
        {
            j.SetActive(true);
        }
        if (timer < -6.5)
        {
            k.SetActive(true);
        }
        if (timer < -7.5)
        {
            l.SetActive(true);
        }
    }
}

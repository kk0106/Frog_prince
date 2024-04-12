using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanBack : MonoBehaviour
{
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
    public GameObject m;

    public float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        


        if (time > 2)
        {
            a.SetActive(true);
            b.SetActive(true);
            c.SetActive(true);
            d.SetActive(true);
            e.SetActive(true);
            f.SetActive(true);
            g.SetActive(true);
            h.SetActive(true);
            i.SetActive(true);
            j.SetActive(true);
            k.SetActive(true);
            l.SetActive(true);
            m.SetActive(true);
         

        }

        if(time > 2.1) { time = 0; }

        if (!a.activeInHierarchy||!b.activeInHierarchy||!c.activeInHierarchy||!d.activeInHierarchy||!e.activeInHierarchy||!f.activeInHierarchy||!g.activeInHierarchy||!h.activeInHierarchy||
            !i.activeInHierarchy||!j.activeInHierarchy||!k.activeInHierarchy||!l.activeInHierarchy||!m.activeInHierarchy)
        {
            time += Time.deltaTime;
        }
    }
}

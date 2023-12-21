using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t1com : MonoBehaviour
{
    public GameObject com1;
    public GameObject com2;
    public GameObject com3;
    public GameObject com4;
    public GameObject com5;
    public GameObject com6;
    public GameObject com7;
    public GameObject com8;
    public GameObject com9;
    public GameObject com10;
    public GameObject com11;
    public GameObject com12;
    public GameObject com13;

    public float time;
    // Start is called before the first frame update
    void Start()
    {
        com1.SetActive(false);
        com2.SetActive(false);
        com3.SetActive(false);
        com4.SetActive(false);
        com5.SetActive(false);
        com6.SetActive(false);
        com7.SetActive(false);
        com8.SetActive(false);
        com9.SetActive(false);
        com10.SetActive(false);
        com11.SetActive(false);
        com12.SetActive(false);
        com13.SetActive(false);


            

    }

    // Update is called once per frame
    void Update()
    {
        if (time < 6)
        {
            com1 .SetActive(true);
        }
        if (time < 5)
        {
            com2 .SetActive(true);
        }
        if (time < 4)
        {
            com2.SetActive (false);
            com3 .SetActive(true);
        }
        if(time < 3)
        {
            com4 .SetActive(true);
        }
        if (time < 2)
        {
            com5 .SetActive(true);
        }
        if (time < 1)
        {
            com6 .SetActive(true);
        }
        if( time < 0)
        {
            com7 .SetActive(true);
        }
        if (time < -1)
        {
            com8 .SetActive(true);
        }
        if (time < -2)
        {
            com9 .SetActive(true);
        }
        if (time < -3)
        {
            com10 .SetActive(true);
        }
        if (time < -4)
        {
            com11 .SetActive(true);
        }
        if (time < -5)
        {
            com12 .SetActive(true);
        }
        if (time < -6)
        {
            com13 .SetActive(true);
        }

        time-=Time.deltaTime;
    }
}

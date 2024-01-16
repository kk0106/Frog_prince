using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatTransform : MonoBehaviour
{
    public Vector3[] point;
    public GameObject cat1;
    public GameObject cat2;
    public GameObject cat3;

    public float time;

    private Animator ani1;
    private Animator ani2;
    private Animator ani3;
    // Start is called before the first frame update
    void Start()
    {
        ani1 = cat1.GetComponent<Animator>();
        ani2 = cat2.GetComponent<Animator>();
        ani3 = cat3.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time > 0)
        {
            ani1.SetBool("out", false);
            ani2.SetBool("out", false);
            ani3.SetBool("out", false);
        }


        if (time > 3)
        {
            cat1.transform.position = point[0];
            cat2.transform.position = point[1];
            cat3.transform.position = point[2];
           
            ani1.SetBool("out", true);
            ani2.SetBool("out", true);
            ani3.SetBool("out", true);
        }

        if (time > 8)
        {
            ani1.SetBool("out", false);
            ani2.SetBool("out", false);
            ani3.SetBool("out", false);
        }


        if (time > 11)
        {
            cat1.transform.position = point[3];
            cat2.transform.position = point[4];
            cat3.transform.position = point[5];

            ani1.SetBool("out", true);
            ani2.SetBool("out", true);
            ani3.SetBool("out", true);
        }


        if (time > 16)
        {
            ani1.SetBool("out", false);
            ani2.SetBool("out", false);
            ani3.SetBool("out", false);
        }


        if (time > 19)
        {
            cat1.transform.position = point[6];
            cat2.transform.position = point[7];
            cat3.transform.position = point[8];

            ani1.SetBool("out", true);
            ani2.SetBool("out", true);
            ani3.SetBool("out", true);
        }
        if (time > 20)
        {
            time = 0;
        }

    }
}

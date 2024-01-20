using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatTransform : MonoBehaviour
{
    public Vector3[] point;
    public GameObject cat1;
    public GameObject cat2;
    public GameObject cat3;
    public GameObject cat4;
    public GameObject cat5;
    public GameObject cat6;

    public float time;

   private Animator ani1;
    private Animator ani2;
    private Animator ani3;
    private Animator ani4;
    private Animator ani5;
    private Animator ani6;
    // Start is called before the first frame update
    void Start()
    {
        ani1 = cat1.GetComponent<Animator>();
        ani2 = cat2.GetComponent<Animator>();
        ani3 = cat3.GetComponent<Animator>();
        ani4 = cat4.GetComponent<Animator>();
        ani5 = cat5.GetComponent<Animator>();
        ani6 = cat6.GetComponent<Animator>();

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
            ani4.SetBool("out", false);
            ani5.SetBool("out", false);
            ani6.SetBool("out", false);
        }


        if (time > 3)
        {
            cat1.transform.position = point[1];
            cat2.transform.position = point[2];
            cat3.transform.position = point[0];
            cat4.transform.position = point[0];
            cat5.transform.position = point[0];
            cat6.transform.position = point[3];

            ani1.SetBool("out", true);
            ani2.SetBool("out", true);
            //ani3.SetBool("out", true);
            //ani4.SetBool("out", true);
           // ani5.SetBool("out", true);
            ani6.SetBool("out", true);
        }

        if (time > 8)
        {
            ani1.SetBool("out", false);
            ani2.SetBool("out", false);
            ani3.SetBool("out", false);
            ani4.SetBool("out", false);
            ani5.SetBool("out", false);
            ani6.SetBool("out", false);

        }

        if (time > 10)
        {
            cat1.transform.position = point[0];
            cat2.transform.position = point[0];
            cat3.transform.position = point[0];
            cat4.transform.position = point[0];
            cat5.transform.position = point[0];
            cat6.transform.position = point[0];
        }

        if (time > 11)
        {
            cat1.transform.position = point[4];
            cat2.transform.position = point[0];
            cat3.transform.position = point[6];
            cat4.transform.position = point[0];
            cat5.transform.position = point[5];
            cat6.transform.position = point[0];

            ani1.SetBool("out", true);
            //ani2.SetBool("out", true);
            ani3.SetBool("out", true);
           // ani4.SetBool("out", true);
            ani5.SetBool("out", true);
           // ani6.SetBool("out", true);
        }


        if (time > 16)
        {
            ani1.SetBool("out", false);
            ani2.SetBool("out", false);
            ani3.SetBool("out", false);
            ani4.SetBool("out", false);
            ani5.SetBool("out", false);
            ani6.SetBool("out", false);
            
        }
        if (time > 18)
        {
            cat1.transform.position = point[0];
            cat2.transform.position = point[0];
            cat3.transform.position = point[0];
            cat4.transform.position = point[0];
            cat5.transform.position = point[0];
            cat6.transform.position = point[0];
        }

            if (time > 19)
        {
            cat1.transform.position = point[0];
            cat2.transform.position = point[8];
            cat3.transform.position = point[9];
            cat4.transform.position = point[7];
            cat5.transform.position = point[0];
            cat6.transform.position = point[0];

           // ani1.SetBool("out", true);
            ani2.SetBool("out", true);
            ani3.SetBool("out", true);
            ani4.SetBool("out", true);
            //ani5.SetBool("out", true);
            //ani6.SetBool("out", true);
        }
        if (time > 20)
        {
            time = 0;
        }

    }
}

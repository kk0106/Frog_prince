using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class card : MonoBehaviour
{
    public GameObject cardd;

    private Animator ani;
    public static int CardDie;
    public GameObject a1;

    public GameObject cam;

    public int a;
    public float time;

    public GameObject cardcollider;

    // Start is called before the first frame update
    void Start()
    {
        ani = cardd.gameObject.GetComponent<Animator>();

        CardDie = 0;

        a = 0;

        cardcollider.SetActive(true);

        a1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (a == 1)
        {
            time -= Time.deltaTime;
        }

        if(time< 0)
        {
   
            CardDie = 1;
        }

        if (time < -0.45f)
        {
           a1.SetActive (true);

            cam.SetActive (true);
        }


        if (time < -1)
        {
            cardcollider.gameObject.SetActive(false);
            this.gameObject.SetActive(false);
            cardd.SetActive(false);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "shoose")
        {
            ani.SetBool("die", true);

            a = 1;
        }
       
    }
}

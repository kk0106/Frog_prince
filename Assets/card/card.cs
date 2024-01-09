using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class card : MonoBehaviour
{
    private Animator ani;
    public static int CardDie;

    public int a;
    public float time;

    public GameObject cardcollider;

    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();

        CardDie = 0;

        a = 0;

        cardcollider.SetActive(true);
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
          
            ani.SetBool("remove", true);

            CardDie = 1;
        }

        if (time < -0.7f)
        {
            cardcollider.gameObject.SetActive(false);
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

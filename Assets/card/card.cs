using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class card : MonoBehaviour
{
    private Animator ani;
    public int a;
    public float time;
    public GameObject cardcollider;

    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();

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

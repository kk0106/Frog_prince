using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossCamTrigger : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject wall;
    public GameObject mushroom1;
    public GameObject mushroom2;
    public GameObject mushroom3;

    private float time;
    public static int a;


    void Start()
    {
        a = 0;


       
        wall.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(a==1)
        {
            time += Time.deltaTime;
        }

        if (time > 1) 
        {
                wall.SetActive(true);

            mushroom1.SetActive(false);
            mushroom2.SetActive(false);
            mushroom3.SetActive(false);
        } 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            a = 1;
        }
    }
}

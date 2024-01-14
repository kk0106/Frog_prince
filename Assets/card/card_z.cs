using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class card_z : MonoBehaviour
{

    public GameObject z1;
    public GameObject z2;
    public GameObject z3;


    public float time;
    // Start is called before the first frame update
    void Start()
    {
        z1.SetActive(false); 
        z2.SetActive(false);
        z3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        

        if(time>1)
        {
            z1.SetActive(true);
        }

        if (time > 1.5)
        {
            z2.SetActive(true);
        }

        if(time > 2)
        {
            z3.SetActive(true);
        }

        if( time > 2.5)
        {
            z1.SetActive(false);
            z2.SetActive(false);
            z3.SetActive(false);
        }

        if (time > 2.6)
        {
            time = 0.5f;
        }
    }
}

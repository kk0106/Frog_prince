using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ismushroom : MonoBehaviour
{
    public static int ismushrooma;
    // Start is called before the first frame update
    void Start()
    {
        ismushrooma = 0;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ismushrooma = 1;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ismushrooma= 1;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ismushrooma = 0;
        }
    }
}

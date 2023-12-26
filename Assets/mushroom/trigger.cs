using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public GameObject cam;
    public static int ismushroom;
    // Start is called before the first frame update
    void Start()
    {
        ismushroom = 0;
        cam.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            cam.SetActive (true);
            ismushroom = 1;
        }


    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            cam.SetActive(true);
            ismushroom = 1;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
           cam.SetActive(false);
                ismushroom = 0;
        }
    }
}

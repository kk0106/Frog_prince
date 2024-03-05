using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appleTip : MonoBehaviour
{
    public GameObject img;
    // Start is called before the first frame update
    void Start()
    {
        img.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            img.SetActive (true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            img.SetActive(false);
        }
    }
}

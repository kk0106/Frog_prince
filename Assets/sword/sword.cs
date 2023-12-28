using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword : MonoBehaviour
{
    public GameObject swordd;
    public GameObject carrdio;
   
    // Start is called before the first frame update
    void Start()
    {
        swordd.SetActive(false);
        carrdio.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            swordd.SetActive (true);
            carrdio.SetActive (true);

        }
    }
}

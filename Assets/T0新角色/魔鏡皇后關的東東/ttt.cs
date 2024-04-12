using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ttt : MonoBehaviour
{
    public GameObject a;
    public GameObject b;
    // Start is called before the first frame update
    void Start()
    {
        a.SetActive(false);
        b.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            a.SetActive (true);
            b.SetActive (true);
        }
    }
}

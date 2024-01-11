using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardStartTriggerValue : MonoBehaviour
{

    public static int start;
    // Start is called before the first frame update
    void Start()
    {
        start = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            start = 1;
        }
    }
}

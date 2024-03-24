using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dess : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Destroy(this.gameObject,12f);
    }

    /*private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "end")
        {
            Destroy(gameObject);
        }
    }*/
}

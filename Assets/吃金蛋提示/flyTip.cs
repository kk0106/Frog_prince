using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyTip : MonoBehaviour
{
    public GameObject tip;

    // Start is called before the first frame update
    void Start()
    {
        tip.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Player")
        {
            tip.SetActive (true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            tip.SetActive (false);
        }
    }
}

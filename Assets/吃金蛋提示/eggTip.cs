using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eggTip : MonoBehaviour
{
    public GameObject panel;
    public float time;
    
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        

      
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            panel.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            panel.SetActive(false);
        }
    }
}

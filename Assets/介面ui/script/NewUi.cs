using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewUi : MonoBehaviour
{

    public GameObject FlyUI;

    // Start is called before the first frame update
    void Start()
    {
        FlyUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            FlyUI.SetActive(true);
                
        }
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            FlyUI.SetActive(true);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            FlyUI.SetActive(false);

        }
    }
}

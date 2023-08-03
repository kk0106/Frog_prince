using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shop : MonoBehaviour
{
    public GameObject shopText;
    // Start is called before the first frame update
    void Start()
    {
        shopText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    private void OnCollisionEnter(Collision collision)
    {
       // other.gameObject.tag = "Player";
        shopText.SetActive(true);
    }

    private void OnCollisionExit(Collision collision)
    {
        //other.gameObject.tag = "Player";
        shopText.SetActive(false);
    }

  
    
}

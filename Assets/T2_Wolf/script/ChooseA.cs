using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseA : MonoBehaviour
{
    public GameObject chooseB;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            FirstChoose.FirstChooseInt = 1;
            chooseB.SetActive(false);    
        }
    }
}

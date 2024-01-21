using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxAttack : MonoBehaviour
{
    public static int a;
   
    // Start is called before the first frame update
    void Start()
    {
        a = 0;
   
      
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {

           
            level1.IsTrueAx = 1;
        }
    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stop : MonoBehaviour
{
    public GameObject A;
   // public GameObject playerr;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(A.activeInHierarchy)
        {
            player.MoveSpeed = 0f;
            player.JumpForce = 0f;
            
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxAttack3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {

            level1.IsTrueAx = 3;
        }
    }
}

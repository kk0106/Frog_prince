using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poisonDes : MonoBehaviour
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
        if (other.gameObject.tag == "apple2" || other.gameObject.tag == "NewApple")
        {
            Destroy(other.gameObject);
        }
    }
}

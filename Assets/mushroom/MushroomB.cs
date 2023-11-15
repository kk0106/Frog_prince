using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomB : MonoBehaviour
{
    public int a;

   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if(a==1)
        {
            Vector3 objectScale = transform.localScale;
            transform.localScale = new Vector3(objectScale.x * 2, objectScale.y * 2, objectScale.z * 2);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            a = 1;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            a = 0;
        }
    }
}

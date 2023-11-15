using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class MushroomA : MonoBehaviour
{
    public float rotSpeed;
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
            transform.Rotate(Vector3.down * rotSpeed, Space.Self);
          
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

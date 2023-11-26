using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 30f; // Adjust the speed as needed
    public GameObject A;
    private int puse;

    void Update()
    {
        if (!A.activeInHierarchy)
        {
            if(puse == 0)
            {
                transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime, Space.Self);
            }
            
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "fightpin")
        {
            puse = 1;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "fightpin")
        {
            puse = 0;
        }
    }
}


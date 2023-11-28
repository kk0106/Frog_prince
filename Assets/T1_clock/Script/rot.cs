using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rot : MonoBehaviour
{
    public float rotationSpeed ; // Adjust the speed as needed
    public GameObject A;
    private int puse;

    void Update()
    {
        if (!A.activeInHierarchy)
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime, Space.Self);
        }
    }

    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "fightpin")
        {
            rotationSpeed = 52f;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "fightpin")
        {
            rotationSpeed = 0f;
        }
    }
}

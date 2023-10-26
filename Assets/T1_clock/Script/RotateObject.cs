using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 30f; // Adjust the speed as needed
    public GameObject A;

    void Update()
    {
        if (!A.activeInHierarchy)
        {

            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime, Space.Self);
        }
    }
}


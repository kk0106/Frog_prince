
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desaa : MonoBehaviour
{

public class DestroyObjectsWithTag : MonoBehaviour
{
    public string tagToDestroy = "ball"; // ���w�n����������

    void Start()
    {
            GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag(tagToDestroy);

       //     if (hp.BeeDes == 1)
       //     {
                foreach (GameObject obj in objectsWithTag)
                {
                    Destroy(obj);
                }
            }
      //  }


    }

void Update()
    {

           
    }

    
}

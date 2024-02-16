using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T0Com : MonoBehaviour
{

    public GameObject t0;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
       

        t0.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time> 4.5)
        {
            t0.SetActive (true);
        }
    }
}

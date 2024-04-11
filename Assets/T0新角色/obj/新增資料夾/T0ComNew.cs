using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T0ComNew : MonoBehaviour
{
    public GameObject pp;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        pp.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (T0Com.change == 1)
        {
            time += Time.deltaTime;
        }

        if (time > 0.67)
        {
            pp.SetActive(true);
            T0Com.change =0;
        }
    }
}

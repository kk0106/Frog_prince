using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spring : MonoBehaviour
{
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer-=Time.deltaTime;

        if (timer > 1.5 && timer < 1.6)
        {

            transform.localScale = new Vector3(1f, 1.2f, 1f);
        }

        if (timer > 1.3 && timer < 1.4)
        {

            transform.localScale = new Vector3(1f, 1.4f, 1f);
        }

        if (timer > 1.1 && timer < 1.2)
        {

            transform.localScale = new Vector3(1f, 1.6f, 1f);
        }
        if (timer > 0.9 && timer < 1)
        {

            transform.localScale = new Vector3(1f, 1.4f, 1f);
        }

        if (timer > 0.7 && timer < 0.8)
        {

            transform.localScale = new Vector3(1f, 1.2f, 1f);
        }

        if (timer < 0.5)
        {
            timer = 2;
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }
}

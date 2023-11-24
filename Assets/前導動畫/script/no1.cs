using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class no1 : MonoBehaviour
{

    public GameObject background;
    //public GameObject ani;
    public float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer-=Time.deltaTime;
        background.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < 0)
        {
            background.SetActive(true);
        }

        if (BUTTON.A == 1) 
        {
            timer -= Time.deltaTime;
        }
    }
}

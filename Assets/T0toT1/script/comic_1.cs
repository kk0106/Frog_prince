using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comic_1 : MonoBehaviour
{
    Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (comic.a == 1)
        {
            ani.SetBool("in", true);
        }
    }
}

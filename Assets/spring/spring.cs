using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spring : MonoBehaviour
{
    public Animator ani;
    public GameObject key;
    // Start is called before the first frame update
    void Start()
    {
        ani=gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!key.activeInHierarchy)
        {
            ani.SetBool("start", true);
        }
    }

}

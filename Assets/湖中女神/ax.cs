using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ax : MonoBehaviour
{
    public Animator ani;
    public int a;
    public float time;
    public GameObject godness;
    // Start is called before the first frame update
    void Start()
    {
        godness.SetActive(false);
        a = 0;
        ani=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (a == 1)
        {
            time-=Time.deltaTime;
        }
        if (time < 1)
        {
            ani.SetBool("down", true);

        }
        if (time < 0)
        {
            godness.SetActive(true); 
            time = 3;
             a = 0;
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            a = 1;
        }
    }
}

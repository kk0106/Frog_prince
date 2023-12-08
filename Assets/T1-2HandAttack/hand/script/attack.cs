using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class attack : MonoBehaviour
{
    public Animator ani;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        ani.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        time-=Time.deltaTime;

        if(time<3)
        {
            ani.SetBool("up", true);
        }
        if (time < 1)
        {
            ani.SetBool("attack", true);
        }
    }


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "ice")
        {
            other.gameObject.SetActive(false);
        }
    }
}

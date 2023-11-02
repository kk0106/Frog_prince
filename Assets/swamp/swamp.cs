using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swamp : MonoBehaviour
{
    public GameObject plan;
    public float time;
    public int a;
    Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        ani= GetComponent<Animator>();
       //lan.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (time == 1.7f)
        {
            ani.SetBool("down", true);
        }
        if (time <0)
        {
           
            plan.SetActive (false);
            Invoke("Re", 1f);
        }
        if(a==1)
        {
            time -= Time.deltaTime;
        }
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            a = 1;
            
        }
    }
    private void Re()
    {
        plan.SetActive(true );
        a = 0;
        time = 2;
    }
}

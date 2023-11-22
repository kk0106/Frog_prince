using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swamp : MonoBehaviour
{
    
    public GameObject plan;
    public float time;
    public int a;
    private float x;
    private float y;
    private float z;
    Animator ani;
    public float DownValue ;
    public Vector3 StartPos;
    
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
        a = 0;
    }

    // Update is called once per frame
    void Update()
    {
       
        DownValue = Random.Range(0.02f,0.007f);
        x =plan.transform.position.x;
        y=plan.transform.position.y;
        z=plan.transform.position.z;
    
        if(a == 1)
        {
            time-= Time.deltaTime;
        }


        if (time >1.9f)
        {
            plan.transform.position = StartPos;
            ani.SetBool("down", false); 
        }
        if (time < 1.51f)
        {
            ani.SetBool("down", true);
        }
       // if (time < 1.5f)
      //  {
       //     plan.transform.position=new Vector3(x,y-DownValue,z);
       // }

        if (time < -0.5f)
        {
            time = 2;
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

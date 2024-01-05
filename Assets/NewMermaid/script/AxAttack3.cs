using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxAttack3 : MonoBehaviour
{
    //private Rigidbody rb;
   // public float speed;
   // private Animator ani;

    public GameObject ax;
    // Start is called before the first frame update
    void Start()
    {
       // rb= GetComponent<Rigidbody>();
       // ani= ax.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {

            level1.IsTrueAx = 3;

          //  ani.SetBool("attack", true);

          //  rb.velocity = Vector3.back * speed;
        }
    }
}

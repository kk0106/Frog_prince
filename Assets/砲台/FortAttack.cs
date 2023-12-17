using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class FortAttack : MonoBehaviour
{
    public Rigidbody pp1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
           
            Rigidbody clonel;
            clonel = Instantiate(pp1, transform.position, transform.rotation) as Rigidbody;
            clonel.velocity = transform.TransformDirection(Vector3.left * 100);

            
        }
        
    }
    private void OnCollisionExit(Collision other)
    {
       this.gameObject.SetActive(false);

    }
}

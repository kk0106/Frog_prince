using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomB : MonoBehaviour
{
    public  int a;
    public float scale;
   // public float timer;
    public float speed;
    public float x;
    public float y;
    public float z;
    
    
   
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {

       

        if (a==1)
        {
            
            Vector3 objectScale = transform.localScale;
            x = objectScale.x=1.8f;
            y = objectScale.y=1.8f;
            z = objectScale.z = 1.8f;
            transform.localScale = new Vector3(x * scale, y * scale, z * scale);

            
        }


        if (x < 0.4&&y<0.4&&z<0.4)
        {
         // this.gameObject.SetActive(false);
        }
        
     
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            a = 1;
           
            other.rigidbody.AddForce(Vector3.up * speed);
        }    
    }


    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            a = 1;
            //  timer -= Time.deltaTime;
            other.rigidbody.AddForce(Vector3.up * speed);
        }
    }


    private void OnCollisionExit(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            a = 0;
           
        }
    }

   
}

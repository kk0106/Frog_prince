using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomB : MonoBehaviour
{
    public float timer;
    
   
    
    
   
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // timer-=Time.deltaTime;


        Vector3 objectScale = transform.localScale;

       

        if (timer > 1.5 && timer < 1.6)
        {

            transform.localScale = new Vector3(1.89326632f, 1.89326632f, 1.89326632f);
        }

        if (timer > 1.3 && timer < 1.4)
        {

            transform.localScale = new Vector3(1.3f, 1.3f, 1.3f);
        }

        if (timer > 1.1 && timer < 1.2)
        {

            transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
        }

        if (timer < 0.9)
        {
            Invoke("re", 2f);
            gameObject.SetActive(false);
           
        } 

    }   


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            timer -= Time.deltaTime*3;
        }
    }

    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            timer -= Time.deltaTime*3;
        }
    }

    private void re()
    {
        timer = 1.7f;
        transform.localScale = new Vector3(1.89326632f, 1.89326632f, 1.89326632f);
       
        gameObject.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMushroom : MonoBehaviour
{
    private int mushroomInt;
    public float time;
    public GameObject player;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        mushroomInt = 3;
        rb=player.GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (mushroomInt < 0)
        {
            this.gameObject.SetActive(false);
            
        }
        if (!this.gameObject.activeInHierarchy)
        {
            time += Time.deltaTime;
        }
        if (mushroomInt == 3)
        {
            this .gameObject.SetActive(true);
        }

        if(time>5)
        {
            mushroomInt = 3;
        }
    }


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            mushroomInt -= 1;
               rb.velocity = new Vector3(rb.velocity.y,7f);
        }
    }
}

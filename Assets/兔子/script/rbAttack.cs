using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rbAttack : MonoBehaviour
{
    public int hp=1;
    Animator ani;
    public GameObject wall;
    public GameObject rb;
    
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();

        wall.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (!rb)
        {
            wall.SetActive(false);
        }
        if(hp==0)
        {
            rb.SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "egg")
        {
            hp -= 1;

            ani.SetBool("hurt", true);
        }
    }

  
    
}

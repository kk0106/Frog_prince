using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.LowLevel;
using UnityEngine.SceneManagement;

public class T1EndRb : MonoBehaviour
{
    public GameObject rb;
    public GameObject com1;
    public GameObject com2;
    public GameObject com3;
    public GameObject com4;
    public GameObject com5;
    public GameObject com6;
    private Animator ani;
   
    private SpriteRenderer spr;
    public Sprite[] img;

    public float time;
    public static int a;
    // Start is called before the first frame update
    void Start()
    {
        rb.SetActive(false);
        a = 0;
        com1.SetActive(false);
        com2.SetActive(false);
        com3.SetActive(false);
        com4.SetActive(false);
        com5.SetActive(false);
        com6.SetActive(false);

        ani = com5.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (a == 1)
        {
            time-=Time.deltaTime;
        }

        if (time < 5)
        {
            com1.SetActive(true);
        }
        if (time < 4)
        {
            com2.SetActive(true);
        }
        if (time < 3)
        {
            spr = com2.GetComponent<SpriteRenderer>();
            spr.sprite = img[0];
        }
        if (time < 2)
        {
            com3.SetActive(true);
        }

        if(time < 1)
        {
            com4.SetActive(true);
        }
        if (time < 0)
        {
            com5.SetActive(true);
        }
        if(time < -1)
        {
            ani.SetBool("atk", true);
        }
        if (time < -1.4)
        {
           com6.SetActive(true);
        }
        if (time < -2)
        {
            SceneManager.LoadScene("T1_Clock");
            a = 0;
        }

        print(a);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            rb.SetActive (true);
            a = 1;
        }
      
    }
    
}

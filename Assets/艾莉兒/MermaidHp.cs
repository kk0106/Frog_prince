using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MermaidHp : MonoBehaviour
{
    public  int hp;
    public GameObject hp6;
    public GameObject hp5;
    public GameObject hp4;
    public GameObject hp3;
    public GameObject hp2;
    public GameObject hp1;
    public GameObject hp0;
    private Animator ani;
    public GameObject godness;

   
    public SpriteRenderer spr;
    public Sprite[] img;
    
    public float time;
    public float time2;


    public GameObject bloom;

    // Start is called before the first frame update
    void Start()
    {
      
        spr = GetComponent<SpriteRenderer>();
        ani = GetComponent<Animator>();
        
        hp1.SetActive(false);
        hp2.SetActive(false);
        hp3.SetActive(false);
        hp4.SetActive(false);
        hp5.SetActive(false);
        hp0.SetActive(false);
        bloom.SetActive(false);
        godness.SetActive(false);
       
    }

    // Update is called once per frame
    void Update()
    {
        if (time2 < 0)
        {
           godness.SetActive(true);
        }
       

        if (time < 0)
        {
            hp -= 1;
            time = 0.3f;
            bloom.SetActive(false);
            spr.sprite = img[0];

            if (hp == 2)
            {
                spr.sprite = img[1];
            }

            if(hp == 1)
            {
                spr.sprite = img[2];
            }
        }
        if (time < 0.11)
        {
            bloom.SetActive(true);
         
        }
        if (hp == 6&&attack1.SetAni==0)
        {
            hp6.SetActive(true);
        }

        if (hp == 5) 
        {
            hp5.SetActive(true);
            hp6.SetActive(false);
        }
        if (hp == 4)
        {
            hp6.SetActive(false);
            hp4.SetActive(true);
            hp5.SetActive(false);

            
        }
        if (hp == 3)
        {
            hp6.SetActive(false);
            hp4.SetActive(false);
            hp5.SetActive(false);
            hp3.SetActive(true);

            spr.sprite = img[2];
        }
        if (hp == 2)
        {
            hp6.SetActive(false);
            hp4.SetActive(false);
            hp5.SetActive(false);
            hp3.SetActive(false);
            hp2.SetActive(true);

            spr.sprite = img[1];
        }
        if (hp == 1)
        {
            hp6.SetActive(false);
            hp4.SetActive(false);
            hp5.SetActive(false);
            hp3.SetActive(false);
            hp1.SetActive(true);
            hp2.SetActive(false);

           spr.sprite = img[1];
            ani.SetBool("die", true);
            time2-= Time.deltaTime;
        }
        if (hp == 0)
        {
            hp6.SetActive(false);
            hp4.SetActive(false);
            hp5.SetActive(false);
            hp3.SetActive(false);
            hp0.SetActive(true);
            hp2.SetActive(false);
            hp1.SetActive(false);
        }

        if (bloom.activeInHierarchy)
        {
            spr.sprite = img[3];
        }
        else
        {
            spr.sprite = img[0];

            if (hp == 2)
            {
                spr.sprite = img[1];
            }

            if (hp == 1)
            {
                spr.sprite = img[2];
            }

        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "pp1")
        {
            //bloom.SetActive(true);
            time-= Time.deltaTime;

            //  hp -= 1;

            


        }
    }
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "pp1")
        {
         //   bloom.SetActive(false);
            Destroy(other.gameObject);

           
        }
    }

}

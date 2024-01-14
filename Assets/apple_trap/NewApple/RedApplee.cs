using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedApplee : MonoBehaviour
{
    [Header("spider")]
    public GameObject sprider;
    public GameObject GoldApple;

    
    public GameObject redgirl;
    public GameObject Redcollider;
    public GameObject cam;
    public static int IsRedCom;

    public GameObject Apple1;
    public GameObject Apple2;
    public GameObject Apple3;
    public int AppleCount;
    private int a;

    public GameObject talkk;
    public GameObject talk;
    public GameObject StartTalk;
    public GameObject basket;

    private SpriteRenderer spr;
    public Sprite[] img;

    private SpriteRenderer spr1;
    public Sprite[] img1;
 
    private SpriteRenderer spr2;
    public Sprite[] img2;

    // private SpriteRenderer spr3;
    //public Sprite[] img3;
    private Animator ani1;

    public float time;
    public float time1;
    // Start is called before the first frame update

    void Start()
    {
        sprider.SetActive(false);
        GoldApple.SetActive(false);

       IsRedCom = 0;

        cam.SetActive(false);

        AppleCount= -2;
        a = 0;

        talk.SetActive(false);
        StartTalk.SetActive(true);

        spr=basket.GetComponent<SpriteRenderer>();

        spr1=talk.GetComponent<SpriteRenderer>();

        spr2=StartTalk.GetComponent<SpriteRenderer>();

        ani1=redgirl.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (AppleCount == -1)
        {
            time-=Time.deltaTime;
        }

        if (time<5)
        {
            spr2.sprite = img2[0];
        }

        if (time <2)
        {
            spr2.sprite = img2[1];
        }

        if (time < 0)
        {
            spr2.sprite = img2[2];
        }

        if (time <-3)
        {
            spr2.sprite = img2[3];
        }

        

        if (time <-5)
        {
            AppleCount = 0;

            talk.SetActive(true);
            StartTalk.SetActive(false);

            cam.SetActive(false);
            IsRedCom = 0;
        }
        

      /*  if(!Apple1.activeInHierarchy)
        {
            Apple2.SetActive(true);    
            Apple3.SetActive(true);
        }
        if (!Apple2.activeInHierarchy)
        {
            Apple3.SetActive(true);
        }
      */

        if (!Apple1.activeInHierarchy)
        {
            AppleCount ++;
        }

        if (!Apple2.activeInHierarchy)
        {
            AppleCount ++;
        }


        if (!Apple3.activeInHierarchy)
        {
            AppleCount ++;
        }




        if (AppleCount==0)
        {
            spr.sprite = img[0];

            spr1.sprite = img1[0];

           
        }

        if(AppleCount==1)
        {
            spr.sprite = img[1];

            spr1.sprite = img1[1];
        }

        if (AppleCount == 2)
        {
            spr.sprite = img[2];

            spr1.sprite = img1[2];
        }

        if (AppleCount == 3)
        {
            spr.sprite = img[3];

            spr1.sprite = img1[3];

           time1-=Time.deltaTime;
        }

        if (time1 < 0)
        {
            AppleCount = 4;
        }
       
        if (time1 < -3)
        {
            AppleCount = 5;

            a = 1;

            sprider.SetActive(true);

            basket.SetActive(false);

           

            ani1.SetBool("bye", true);
        }

        if (AppleCount == 5)
        {
            StartTalk.SetActive(false);
            talk.SetActive(false);  
            talkk.SetActive(false);
        }

        if (AppleCount == 4)
        {
            spr.sprite = img[3];

            spr2.sprite = img2[4];

            ani1.SetBool("happy", true);
            talk.SetActive(false);
            StartTalk.SetActive(true);


           
            Redcollider.SetActive(false);

            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            AppleCount = -1;

            IsRedCom = 1;

            cam.SetActive(true);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedApplee : MonoBehaviour
{

    public GameObject Apple1;
    public GameObject Apple2;
    public GameObject Apple3;
    public int AppleCount;
    private int a;

    public GameObject talk;
    public GameObject StartTalk;
    public GameObject basket;

    private SpriteRenderer spr;
    public Sprite[] img;

    private SpriteRenderer spr1;
    public Sprite[] img1;
 
    private SpriteRenderer spr2;
    public Sprite[] img2;

    private SpriteRenderer spr3;
    public Sprite[] img3;

    public float time;
    public float time1;
    // Start is called before the first frame update

    void Start()
    {
        AppleCount= -2;
        a = 0;

        talk.SetActive(false);
        StartTalk.SetActive(true);

        spr=basket.GetComponent<SpriteRenderer>();

        spr1=talk.GetComponent<SpriteRenderer>();

        spr2=StartTalk.GetComponent<SpriteRenderer>();

        spr3=this.gameObject.GetComponent<SpriteRenderer>();
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

        if (time <3.5)
        {
            spr2.sprite = img2[1];
        }

        if (time < 2)
        {
            spr2.sprite = img2[2];
        }

        if (time <0.5)
        {
            spr2.sprite = img2[3];
        }

        if(time<-1)
        {
            spr2.sprite = img2[4];
        }

        if (time <-1.8)
        {
            AppleCount = 0;

            talk.SetActive(true);
            StartTalk.SetActive(false);
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
            AppleCount = 1;
        }

        if (!Apple2.activeInHierarchy)
        {
            AppleCount = 2;
        }


        if (!Apple3.activeInHierarchy)
        {
            AppleCount = 3;
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

        if (AppleCount == 4)
        {
            spr.sprite = img[3];

            spr2.sprite = img2[5];

            spr3.sprite = img3[1];
            talk.SetActive(false);
            StartTalk.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            AppleCount = -1;
        }
    }
}

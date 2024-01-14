using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoose : MonoBehaviour
{

    public GameObject cardd;
    public GameObject shooses;
    public GameObject shooses2;
    
    public GameObject cindy;
    public GameObject talk;
    public GameObject talkCam; 
    private SpriteRenderer cindySpr;
    private SpriteRenderer talkSpr;


    public static int isEnd;

    public Sprite[] Cindyimg;
    public Sprite[] Talkimg;
    public float time;
    public float talkTime;
    public float FinishTime;
    // Start is called before the first frame update
    void Start()
    {
        cindySpr=cindy.GetComponent<SpriteRenderer>();
        talkSpr = talk.GetComponent<SpriteRenderer>();

       
        talk.gameObject.SetActive(false);
        talkCam.gameObject.SetActive(false);

        shooses2.SetActive(false);

        isEnd = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!shooses.activeInHierarchy&&card.CardDie==0&&ShootGun.shoseShot==1)
        {
            time-=Time.deltaTime;
            
        }
        if (shooses2.activeInHierarchy)
        {
            if (BreakableObject.a < 5)
            {
                shooses2.SetActive(false) ;
            }
        }

        if (time < 0)
        {
            talkCam.SetActive(true);

            talkTime-=Time.deltaTime;
        }

        if (talkTime < 3)
        {
            talk.SetActive(true);
            talkSpr.sprite = Talkimg[0];
        }

        if(talkTime < 2)
        {
            talkSpr.sprite = Talkimg[1];
            cindySpr.sprite = Cindyimg[1];
        }
        if (talkTime < 0.5)
        {
            time = 5;
            shooses2.SetActive(true);
            talkCam.SetActive(false);
            talk.SetActive(false) ;
        }


        if (!cardd.activeInHierarchy)
        {
            FinishTime-= Time.deltaTime;
            cindySpr.sprite = Cindyimg[2];

            talk.transform.position=new Vector3 (5.42f, 1, -30.02f);
        }

        if(FinishTime<4)
        {
            talkCam.SetActive(true) ;
            

            isEnd = 1;
        }

        if (FinishTime < 3.8)
        {
            talkSpr.sprite = Talkimg[2];
            talk.SetActive(true);
        }

        if(FinishTime < 0)
        {
            talkCam.SetActive(false);
            talk.SetActive(false);

            isEnd = 0;
        }

        
    }
}

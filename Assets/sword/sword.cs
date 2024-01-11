using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class sword : MonoBehaviour
{
    private CinemachineImpulseSource impulseSource;
    [SerializeField] private ScreeenShakeProfile profile;

    public GameObject swordd;
    public GameObject carrdio;

  //  public GameObject cam;

    [Header("TalkChange")]
    private SpriteRenderer spr_talk;
    public Sprite[] img;
    public GameObject talk_person;
    public float time;
    public static int a;

    // Start is called before the first frame update
    void Start()
    {
       // cam.SetActive(false);

        profile.impactForce = 1;
        swordd.SetActive(false);
        carrdio.SetActive(false);

        spr_talk=talk_person.GetComponent<SpriteRenderer>();

        impulseSource=GetComponent<CinemachineImpulseSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(a);

        if (a==1||a==2||a==3||a==4)
        {
           
           time-=Time.deltaTime;

          // cam.SetActive(true);
        }
        if (time < 0.9)
        {
            spr_talk.sprite = img[1];
        }
        if (time < 1)
        {
           
            carrdio.SetActive(true);
            a = 2;
        }
        if (time < 0.9)
        {
            a = 3;
        }


        if (time < 0)
        {
            a = 4;
            
        }

        if (a==4)
        {
            spr_talk.sprite = img[2];
        }

        

        if (a == 2)
        {
            CameraShakeManger.Instance.ScreenShakeFromProfile(profile, impulseSource);
        }

        if (a == 3)
        {
            profile.impactForce = 0;
             // CameraShakeManger.Instance;
            
        }

        if (a < -0.2)
        {
            a = 0;
            profile.impactForce = 1;
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            swordd.SetActive(true);

            a = 1;
            
        }
    }

   
}

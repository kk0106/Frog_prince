using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 魔鏡hp : MonoBehaviour
{
    public float time;
    public GameObject boom;
   
    public int hp;
    public GameObject BOSS;
    private SpriteRenderer spr;
    public Sprite[] img;

    AudioManager audioManager;
    private bool hasPlayedSFX3 = false;
    private bool hasPlayedSFX2 = false;
    private bool hasPlayedSFX = false;
    // Start is called before the first frame update
    void Start()
    {
        BOSS.SetActive(true);
        hp = 3;

        boom.SetActive(false);

      spr = BOSS.GetComponent<SpriteRenderer>();
    }

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    // Update is called once per frame
    void Update()
    {
        if (hp < 0)
        {
            time-=Time.deltaTime;
        }

        if(time<1.5 && !hasPlayedSFX3)
        {
            boom.SetActive(true);
            AudioManager.Instance.PlaySFX(AudioManager.Instance.glass3);
            hasPlayedSFX3 = true;
        }

        if(time< 0.6)
        {
            BOSS.gameObject.SetActive(false);

        }

        if (hp == 3)
        {
            spr.sprite = img[0];
           
        }
        if(hp == 2 && !hasPlayedSFX)
        {
            spr.sprite = img[1];
            AudioManager.Instance.PlaySFX(AudioManager.Instance.glass1);
            hasPlayedSFX = true;
        }
        if (hp == 1 && !hasPlayedSFX2)
        {
            spr.sprite = img[2];
            AudioManager.Instance.PlaySFX(AudioManager.Instance.glass2);
            hasPlayedSFX2 = true; // Update the flag to indicate that the sound has been played
        }

    }


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "NewApple"&&WichTurnFace.CanAttack==1)
        {
            hp -= 1;

            Destroy(other.gameObject);
        }
    }
}

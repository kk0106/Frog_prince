using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHp : MonoBehaviour
{
    [Header("Start")]
    public GameObject boss;
    public GameObject bloom;
    public float time;
    public GameObject StartHp;

    [Header("LevelSetting")]
    public static int WhatLevelNow;

    [Header("hp")]
    public GameObject hp;
    public int hpint;
    private Image HpSpr;
    public Sprite[] Hpimg;

    [Header("Boss")]
    public Sprite[] BossImg;
    public SpriteRenderer BossSpr;
    public float BossHurtTime;
    public bool BossHurt;
    
    [Header("Godness")]
    public GameObject godness;
    private Animator ani;
    public float GodTime;
    // Start is called before the first frame update
    void Start()
    {
        godness.SetActive(false);

        bloom.SetActive(false);
        boss.SetActive(false);
        hp.SetActive(false);
        StartHp.SetActive(false);

        hpint = 6;

        HpSpr =hp.GetComponent<Image>();

        BossSpr =boss.GetComponent<SpriteRenderer>();

        ani=godness.GetComponent<Animator>();   

        WhatLevelNow =1;

        BossHurt =false;
    }

    // Update is called once per frame
    void Update()
    {
        if (godness.activeInHierarchy)
        {
            GodTime += Time.deltaTime;
        }
        if (GodTime > 1)
        {
            ani.SetBool("normal", true);
        }

        if (BossHurt)
        {
            BossSpr.sprite = BossImg[0];

            BossHurtTime += Time.deltaTime;
        }

        if (BossHurtTime > 2)
        {
            BossSpr.sprite = BossImg[1];

            if(hpint>4)
            {
                BossSpr.sprite = BossImg[1];
            }

            if (hpint > 2&&hpint<5)
            {
                BossSpr.sprite = BossImg[2];
            }

            if (hpint > 0 && hpint < 3)
            {
                BossSpr.sprite = BossImg[3];
            }
        }

        if (BossHurtTime > 2.5)
        {
            BossHurt=false;
            BossHurtTime = 0;
        }


        //起始設定(含動畫)
        time += Time.deltaTime;

        if (time > 1)
        {
            bloom.SetActive (true);
        }


        if (time > 1.5)
        {
            boss.SetActive(true);
        }
        if (time > 2)
        {
           StartHp.SetActive(true);
        }

        if (time > 2.5)
        {
            level1.StartGame = 1;
        }

        if (time > 3)
        {
            hp.SetActive (true);
            StartHp.SetActive(false) ;
        }

        //血量設定
        if (hpint == 6)
        {
            HpSpr.sprite = Hpimg[0];

            BossSpr.sprite = BossImg[1];

            WhatLevelNow = 1;
        }
        if (hpint == 5)
        {
            HpSpr.sprite = Hpimg[1];

            BossSpr.sprite = BossImg[1];

            WhatLevelNow = 2;
        }
        if (hpint == 4)
        {
            HpSpr.sprite = Hpimg[2];

            BossSpr.sprite = BossImg[2];

            WhatLevelNow = 3;
        }
        if (hpint == 3)
        {
            HpSpr.sprite = Hpimg[3];

            BossSpr.sprite = BossImg[2];

            WhatLevelNow = 4;
        }
        if (hpint == 2)
        {
            HpSpr.sprite = Hpimg[4];

            BossSpr.sprite = BossImg[3];

            WhatLevelNow = 5;
        }
        if (hpint == 1)
        {
            HpSpr.sprite = Hpimg[5];

            BossSpr.sprite = BossImg[3];

            WhatLevelNow = 6;
        }
        if (hpint == 0)
        {
            HpSpr.sprite = Hpimg[6];

            BossSpr.sprite = BossImg[3];
            
            WhatLevelNow = 7;

            godness.SetActive(true);
            boss.SetActive(false);
            hp.SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ax")
        {
            hpint -= 1;
            BossHurt = true;
        }
    }
}

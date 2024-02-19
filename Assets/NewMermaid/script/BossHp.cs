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
    // Start is called before the first frame update
    void Start()
    {
        bloom.SetActive(false);
        boss.SetActive(false);
        hp.SetActive(false);
        StartHp.SetActive(false);

        hpint = 6;

        HpSpr =hp.GetComponent<Image>();


        WhatLevelNow =1;
    }

    // Update is called once per frame
    void Update()
    {
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

            WhatLevelNow = 1;
        }
        if (hpint == 5)
        {
            HpSpr.sprite = Hpimg[1];

            WhatLevelNow = 2;
        }
        if (hpint == 4)
        {
            HpSpr.sprite = Hpimg[2];
        }
        if (hpint == 3)
        {
            HpSpr.sprite = Hpimg[3];
        }
        if (hpint == 2)
        {
            HpSpr.sprite = Hpimg[4];
        }
        if (hpint == 1)
        {
            HpSpr.sprite = Hpimg[5];
        }
        if (hpint == 0)
        {
            HpSpr.sprite = Hpimg[6];
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ax")
        {
            hpint -= 1;
        }
    }
}

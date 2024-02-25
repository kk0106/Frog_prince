using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level3 : MonoBehaviour
{
    [Header("attack")]
    public GameObject AxAttackButton;//斧頭攻擊開關
    public GameObject ax;


    [Header("hand")]
    public GameObject hand1;
    public GameObject hand2;
    public GameObject hand3;
    public GameObject hand4;
    public GameObject hand5;
    public GameObject hand6;


    [Header("HandAni")]
    private Animator ani1;
    private Animator ani2;
    private Animator ani3;
    private Animator ani4;
    private Animator ani5;
    private Animator ani6;


    public int Setting;

    [Header("LevelValue")]
    public static int levelValue;
    public float time;
    public int BackGround;
    public static int StartGame;

    [Header("ice")]
    public GameObject ice1;
    public GameObject ice2;
    public GameObject ice3;
    public GameObject ice4;
    public GameObject ice5;
    public GameObject ice6;
    public GameObject ice7;
    public GameObject ice8;
    public GameObject ice9;
    public GameObject ice10;
    public GameObject ice11;
    public GameObject ice12;
    public GameObject ice13;
    public GameObject ice14;
    public GameObject ice15;
    public GameObject ice16;
    public GameObject ice17;
    public GameObject ice18;
    public GameObject ice19;


    [Header("IceMatrial")]
    public Material[] material;
    public int mark;

    // Start is called before the first frame update
    void Start()
    {
        StartGame = 0;



        mark = 0;
        levelValue = 1;
        BackGround = 0;
        Setting = 0;

        ani1 = hand1.GetComponent<Animator>();
        ani2 = hand2.GetComponent<Animator>();
        ani3 = hand3.GetComponent<Animator>();
        ani4 = hand4.GetComponent<Animator>();
        ani5 = hand5.GetComponent<Animator>();
        ani6 = hand6.GetComponent<Animator>();




        AxAttackButton.SetActive(false);


        hand1.SetActive(false);//直1
        hand2.SetActive(false);//直2
        hand3.SetActive(false);//直3
        hand4.SetActive(false);//直4
        hand5.SetActive(false);
        hand6.SetActive(false);


        ice1.SetActive(true);
        ice2.SetActive(true);
        ice3.SetActive(true);
        ice4.SetActive(true);
        ice5.SetActive(true);
        ice6.SetActive(true);
        ice7.SetActive(true);
        ice8.SetActive(true);
        ice9.SetActive(true);
        ice10.SetActive(true);
        ice11.SetActive(true);
        ice12.SetActive(true);
        ice13.SetActive(true);


    }

    // Update is called once per frame
    void Update()
    {

        if (BackGround == 0)
        {
            //回復場地
            ice1.SetActive(true);
            ice2.SetActive(true);
            ice3.SetActive(true);
            ice4.SetActive(true);
            ice5.SetActive(true);
            ice6.SetActive(true);
            ice7.SetActive(true);
            ice8.SetActive(true);
            ice9.SetActive(true);
            ice10.SetActive(true);
            ice11.SetActive(true);
            ice12.SetActive(true);
            ice13.SetActive(true);
            ice14.SetActive(true);
            ice15.SetActive(true);
            ice16.SetActive(true);
            ice17.SetActive(true);
            ice18.SetActive(true);
            ice19.SetActive(true);

        }
        if (BackGround == 1)
        {
            
            ice2.SetActive(false);
            ice3.SetActive(false);
            ice4.SetActive(false);

        }

        if (BackGround == 2)
        {
            ice5.SetActive(false);
            ice6.SetActive(false);
            ice7.SetActive(false);
            ice8.SetActive(false);
            ice9.SetActive(false);

            ice10.SetActive(false);
            ice11.SetActive(false);
            ice12.SetActive(false);
            ice2.SetActive(false);
            ice13.SetActive(false);
           


        }

        if (BackGround == 3)
        {
            ice14.SetActive(false);
            ice11.SetActive(false);
            ice15.SetActive(false);
            ice4.SetActive(false);
            ice16.SetActive(false);

            ice17.SetActive(false);
            ice5.SetActive(false);
            ice6.SetActive(false);
            ice18.SetActive(false);
            ice1.SetActive(false);
            ice19.SetActive(false);
            ice2.SetActive(false);
            ice12.SetActive(false);
            ice3.SetActive(false);

        }


        if (mark == 0)
        {
            ice1.GetComponent<Renderer>().sharedMaterial = material[0];
            ice2.GetComponent<Renderer>().sharedMaterial = material[0];
            ice3.GetComponent<Renderer>().sharedMaterial = material[0];
            ice4.GetComponent<Renderer>().sharedMaterial = material[0];
            ice5.GetComponent<Renderer>().sharedMaterial = material[0];
            ice6.GetComponent<Renderer>().sharedMaterial = material[0];
            ice7.GetComponent<Renderer>().sharedMaterial = material[0];
            ice8.GetComponent<Renderer>().sharedMaterial = material[0];
            ice9.GetComponent<Renderer>().sharedMaterial = material[0];
            ice10.GetComponent<Renderer>().sharedMaterial = material[0];
            ice11.GetComponent<Renderer>().sharedMaterial = material[0];
            ice12.GetComponent<Renderer>().sharedMaterial = material[0];
            ice13.GetComponent<Renderer>().sharedMaterial = material[0];
            ice14.GetComponent<Renderer>().sharedMaterial = material[0];
            ice15.GetComponent<Renderer>().sharedMaterial = material[0];
            ice16.GetComponent<Renderer>().sharedMaterial = material[0];
            ice17.GetComponent<Renderer>().sharedMaterial = material[0];
            ice18.GetComponent<Renderer>().sharedMaterial = material[0];
            ice19.GetComponent<Renderer>().sharedMaterial = material[0];
            


        }

        if (mark == 1)
        {
            
            ice2.GetComponent<Renderer>().sharedMaterial = material[1];
            ice3.GetComponent<Renderer>().sharedMaterial = material[1];
            ice4.GetComponent<Renderer>().sharedMaterial = material[1];

        }


        if (mark == 2)
        {
            ice5.GetComponent<Renderer>().sharedMaterial = material[1];
            ice6.GetComponent<Renderer>().sharedMaterial = material[1];
            ice7.GetComponent<Renderer>().sharedMaterial = material[1];
            ice8.GetComponent<Renderer>().sharedMaterial = material[1];
            ice9.GetComponent<Renderer>().sharedMaterial = material[1];
            ice10.GetComponent<Renderer>().sharedMaterial = material[1];
            ice11.GetComponent<Renderer>().sharedMaterial = material[1];
            ice12.GetComponent<Renderer>().sharedMaterial = material[1];
            ice2.GetComponent<Renderer>().sharedMaterial = material[1];
            ice13.GetComponent<Renderer>().sharedMaterial = material[1];     

        }
        if (mark == 3)
        {
            ice14.GetComponent<Renderer>().sharedMaterial = material[1];
            ice11.GetComponent<Renderer>().sharedMaterial = material[1];
            ice15.GetComponent<Renderer>().sharedMaterial = material[1];
            ice4.GetComponent<Renderer>().sharedMaterial = material[1];
            ice16.GetComponent<Renderer>().sharedMaterial = material[1];
            ice17.GetComponent<Renderer>().sharedMaterial = material[1];
            ice5.GetComponent<Renderer>().sharedMaterial = material[1];
            ice6.GetComponent<Renderer>().sharedMaterial = material[1];
            ice18.GetComponent<Renderer>().sharedMaterial = material[1];
            ice1.GetComponent<Renderer>().sharedMaterial = material[1];
            ice19.GetComponent<Renderer>().sharedMaterial = material[1];
            ice2.GetComponent<Renderer>().sharedMaterial = material[1];
            ice12.GetComponent<Renderer>().sharedMaterial = material[1];
            ice3.GetComponent<Renderer>().sharedMaterial = material[1];
           
        }


        if (levelValue != 0)
        {
            time += Time.deltaTime;
        }

        //攻擊1
        if (levelValue == 1)
        {
            //觸手出現，標記地板
            if (time > 0)
            {
                hand1.SetActive(true);
            }

            if (time > 0.4)
            {
                mark = 1;

                ice1.SetActive(false);
            }

            //觸手上升動畫
            if (time > 0.3)
            {
                ani1.SetBool("up", true);
                ani1.SetBool("normal", false);
                ani1.SetBool("attack", false);
                //Setting = 1;
            }

            //觸手攻擊動畫
            if (time > 1.4)
            {
                ani1.SetBool("attack", true);
                ani1.SetBool("normal", false);
                ani1.SetBool("up", false);


            }

            //地板消失
            if (time > 1.6)
            {
                BackGround = 1;
                mark = 0;
            }



            if (time > 2.5)
            {
                BackGround = 0;
            }

            //恢復觸手動畫
            if (time > 1.6)
            {
                ani1.SetBool("normal", true);
                ani1.SetBool("up", false);
                ani1.SetBool("attack", false);
            }

            //觸手消失
            if (time > 3)
            {
                hand1.SetActive(false);
            }

            //進入攻擊2
            if (time > 3.5)
            {
                levelValue = 2;
                time = 0;
            }

        }

        if (levelValue == 2)
        {
            //觸手出現，標記地板
            if (time > 0)
            {
                hand2.SetActive(true);
                hand3.SetActive(true);
            }

            if (time > 0.4)
            {
                mark = 2;
            }

            //觸手上升動畫
            if (time > 0.3)
            {
                ani2.SetBool("up", true);
                ani2.SetBool("normal", false);
                ani2.SetBool("attack", false);
                //Setting = 1;
                ani3.SetBool("up", true);
                ani3.SetBool("normal", false);
                ani3.SetBool("attack", false);
            }

            //觸手攻擊動畫
            if (time > 1.4)
            {
                ani2.SetBool("attack", true);
                ani2.SetBool("normal", false);
                ani2.SetBool("up", false);

                ani3.SetBool("attack", true);
                ani3.SetBool("normal", false);
                ani3.SetBool("up", false);

            }

            //地板消失
            if (time > 1.6)
            {
                BackGround = 2;
                mark = 0;
            }



            if (time > 2.5)
            {
                BackGround = 0;
            }

            //恢復觸手動畫
            if (time > 1.6)
            {
                ani2.SetBool("normal", true);
                ani2.SetBool("up", false);
                ani2.SetBool("attack", false);

                ani3.SetBool("normal", true);
                ani3.SetBool("up", false);
                ani3.SetBool("attack", false);
            }

            //觸手消失
            if (time > 3)
            {
                hand2.SetActive(false);
                hand3.SetActive(false);
            }

            //進入攻擊2
            if (time > 3.5)
            {
                levelValue = 3;
                time = 0;
            }

        }

        if (levelValue == 3)
        {
            //觸手出現，標記地板
            if (time > 0)
            {
                hand5.SetActive(true);
                hand4.SetActive(true);
            }

            if (time > 0.4)
            {
                mark = 3;
            }

            //觸手上升動畫
            if (time > 0.3)
            {
                ani5.SetBool("up", true);
                ani5.SetBool("normal", false);
                ani5.SetBool("attack", false);
                //Setting = 1;
                ani4.SetBool("up", true);
                ani4.SetBool("normal", false);
                ani4.SetBool("attack", false);
            }

            //觸手攻擊動畫
            if (time > 1.4)
            {
                ani5.SetBool("attack", true);
                ani5.SetBool("normal", false);
                ani5.SetBool("up", false);

                ani4.SetBool("attack", true);
                ani4.SetBool("normal", false);
                ani4.SetBool("up", false);
            }

            //地板消失
            if (time > 1.6)
            {
                BackGround = 3;
                mark = 0;
            }



            if (time > 2.5)
            {
                BackGround = 0;
            }

            //恢復觸手動畫
            if (time > 1.6)
            {
                ani5.SetBool("normal", true);
                ani5.SetBool("up", false);
                ani5.SetBool("attack", false);

                ani4.SetBool("normal", true);
                ani4.SetBool("up", false);
                ani4.SetBool("attack", false);
            }

            //觸手消失
            if (time > 3)
            {
                hand5.SetActive(false);
                hand4.SetActive(false);
            }

            //進入攻擊2
            if (time > 3.5)
            {
                levelValue = 4;
                time = 0;
            }

        }



        if (levelValue == 4)
        {
            //觸手出現，標記地板
            if (time > 0)
            {
                hand6.SetActive(true);

            }

            if (time > 0.4)
            {
                mark = 0;
            }

            //觸手上升動畫
            if (time > 0.3)
            {
                ani6.SetBool("up", true);
                ani6.SetBool("normal", false);
                ani6.SetBool("attack", false);

            }

            //觸手攻擊動畫
            if (time > 1.4)
            {
                ani6.SetBool("attack", true);
                ani6.SetBool("normal", false);
                ani6.SetBool("up", false);

            }

            //地板消失
            if (time > 3)
            {
                BackGround = 0;
                mark = 0;
            }



            if (time > 2.5)
            {
                BackGround = 0;
            }

            //恢復觸手動畫
            if (time > 3)
            {
                ani6.SetBool("normal", true);
                ani6.SetBool("up", false);
                ani6.SetBool("attack", false);
            }

            //觸手消失
            if (time > 3)
            {
                hand6.SetActive(false);

            }

            //進入攻擊2
            if (time > 3.5)
            {
                levelValue = 5;
                time = 0;
            }

        }

        if (levelValue == 5)
        {
            //觸手出現，標記地板
            if (time > 0)
            {
                AxAttackButton.SetActive(true);

            }


            if (time > 5)
            {
                AxAttackButton.SetActive(false);
            }


            if (time > 6)
            {
                if (BossHp.WhatLevelNow == 4)
                {
                    levelValue = 7;
                    time = 0;

                    ax.SetActive(false);




                }
                else if (BossHp.WhatLevelNow == 3)
                {
                    levelValue = 1;
                    time = 0;

                    ax.SetActive(false);

                }
            }

        }
    }
}

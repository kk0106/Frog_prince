using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level6 : MonoBehaviour
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
    public GameObject hand7;
    public GameObject hand8;
    public GameObject hand9;
    public GameObject hand10;
    public GameObject hand11;
    


    [Header("HandAni")]
    private Animator ani1;
    private Animator ani2;
    private Animator ani3;
    private Animator ani4;
    private Animator ani5;
    private Animator ani6;
    private Animator ani7;
    private Animator ani8;
    private Animator ani9;
    private Animator ani10;
    private Animator ani11;


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
    public GameObject ice20;
    public GameObject ice21;
    public GameObject ice22;
    public GameObject ice23;
    public GameObject ice24;
    public GameObject ice25;
    public GameObject ice26;
    public GameObject ice27;
    public GameObject ice28;
    public GameObject ice29;
    public GameObject ice30;
    public GameObject ice31;
    public GameObject ice32;
    public GameObject ice33;
    public GameObject ice34;
    public GameObject ice35;
   


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
        ani7 = hand7.GetComponent<Animator>();
        ani8 = hand8.GetComponent<Animator>();
        ani9 = hand9.GetComponent<Animator>();
        ani10 = hand10.GetComponent<Animator>();
        ani11 = hand11.GetComponent<Animator>();





        AxAttackButton.SetActive(false);


        hand1.SetActive(false);//直1
        hand2.SetActive(false);//直2
        hand3.SetActive(false);//直3
        hand4.SetActive(false);//直4
        hand5.SetActive(false);//直1
        hand6.SetActive(false);//直2
        hand7.SetActive(false);//直3
        hand8.SetActive(false);//直4
        hand9.SetActive(false);
        hand10.SetActive(false);
        hand11.SetActive(false);


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
        ice20.SetActive(true);
        ice21.SetActive(true);
        ice22.SetActive(true);
        ice23.SetActive(true);
        ice24.SetActive(true);
        ice25.SetActive(true);
        ice26.SetActive(true);
        ice27.SetActive(true);
        ice28.SetActive(true);
        ice29.SetActive(true);
        ice30.SetActive(true);
        ice31.SetActive(true);
        ice32.SetActive(true);
        ice33.SetActive(true);
        ice34.SetActive(true);
        ice35.SetActive(true);


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
            ice20.SetActive(true);
            ice21.SetActive(true);
            ice22.SetActive(true);
            ice23.SetActive(true);
            ice24.SetActive(true);
            ice25.SetActive(true);
            ice26.SetActive(true);
            ice27.SetActive(true);
            ice28.SetActive(true);
            ice29.SetActive(true);
            ice30.SetActive(true);
            ice31.SetActive(true);
            ice32.SetActive(true);
            ice33.SetActive(true);
            ice34.SetActive(true);
            ice35.SetActive(true);

        }
        if (BackGround == 1)
        {
            ice1.SetActive(false);
            ice2.SetActive(false);
            ice3.SetActive(false);
            ice4.SetActive(false);
            ice5.SetActive(false);
            
        }

        if (BackGround == 2)
        {
            ice6.SetActive(false);
            ice7.SetActive(false);
            ice8.SetActive(false);
            ice9.SetActive(false);
            ice10.SetActive(false);
           
        }

        if (BackGround == 3)
        {
            ice11.SetActive(false);
            ice12.SetActive(false);
            ice13.SetActive(false);
            ice14.SetActive(false);
            ice15.SetActive(false);
           
        }

        if (BackGround == 4)
        {
            ice16.SetActive(false);
            ice17.SetActive(false);
            ice18.SetActive(false);
            ice19.SetActive(false);
            ice20.SetActive(false);

        }

        if (BackGround == 5)
        {
            ice21.SetActive(false);
            ice22.SetActive(false);
            ice23.SetActive(false);
            ice24.SetActive(false);
            ice25.SetActive(false);

        }

        if (BackGround == 6)
        {
            ice26.SetActive(false);
            ice27.SetActive(false);
            ice28.SetActive(false);
            ice29.SetActive(false);
            ice30.SetActive(false);

        }

        if (BackGround == 7)
        {
            ice31.SetActive(false);
            ice32.SetActive(false);
            ice33.SetActive(false);
            ice34.SetActive(false);
            ice35.SetActive(false);

        }

        if (BackGround == 8)
        {
            ice26.SetActive(false);
            ice21.SetActive(false);
            ice17.SetActive(false);
            ice12.SetActive(false);
            ice8.SetActive(false);

        }

        if (BackGround == 9)
        {
            ice1.SetActive(false);
            ice7.SetActive(false);
            ice12.SetActive(false);
            ice18.SetActive(false);
            ice23.SetActive(false);
            ice29.SetActive(false);

        }

        if (BackGround == 10)
        {
            ice32.SetActive(false);
            ice28.SetActive(false);
            ice23.SetActive(false);
            ice19.SetActive(false);
            ice14.SetActive(false);

        }

        if (BackGround == 11)
        {
            ice3.SetActive(false);
            ice9.SetActive(false);
            ice14.SetActive(false);
            ice20.SetActive(false);
            ice25.SetActive(false);

        }

        if (BackGround == 12)
        {
            ice3.SetActive(false);
            ice9.SetActive(false);
            ice14.SetActive(false);
            ice20.SetActive(false);
            ice25.SetActive(false);
            ice26.SetActive(false);
            ice21.SetActive(false);
            ice17.SetActive(false);
            ice12.SetActive(false);
            ice8.SetActive(false);
            ice1.SetActive(false);
            ice7.SetActive(false);
            ice12.SetActive(false);
            ice18.SetActive(false);
            ice23.SetActive(false);
            ice29.SetActive(false);
            ice32.SetActive(false);
            ice28.SetActive(false);
            ice23.SetActive(false);
            ice19.SetActive(false);
            ice14.SetActive(false);


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
            ice20.GetComponent<Renderer>().sharedMaterial = material[0];
            ice21.GetComponent<Renderer>().sharedMaterial = material[0];
            ice22.GetComponent<Renderer>().sharedMaterial = material[0];
            ice23.GetComponent<Renderer>().sharedMaterial = material[0];
            ice24.GetComponent<Renderer>().sharedMaterial = material[0];
            ice25.GetComponent<Renderer>().sharedMaterial = material[0];
            ice26.GetComponent<Renderer>().sharedMaterial = material[0];
            ice27.GetComponent<Renderer>().sharedMaterial = material[0];
            ice28.GetComponent<Renderer>().sharedMaterial = material[0];
            ice29.GetComponent<Renderer>().sharedMaterial = material[0];
            ice30.GetComponent<Renderer>().sharedMaterial = material[0];
            ice31.GetComponent<Renderer>().sharedMaterial = material[0];
            ice32.GetComponent<Renderer>().sharedMaterial = material[0];
            ice33.GetComponent<Renderer>().sharedMaterial = material[0];
            ice34.GetComponent<Renderer>().sharedMaterial = material[0];
            ice35.GetComponent<Renderer>().sharedMaterial = material[0];


        }

        if (mark == 1)
        {
            ice1.GetComponent<Renderer>().sharedMaterial = material[1];
            ice2.GetComponent<Renderer>().sharedMaterial = material[1];
            ice3.GetComponent<Renderer>().sharedMaterial = material[1];
            ice4.GetComponent<Renderer>().sharedMaterial = material[1];
            ice5.GetComponent<Renderer>().sharedMaterial = material[1];
          
        }


        if (mark == 2)
        {
            ice6.GetComponent<Renderer>().sharedMaterial = material[1];
            ice7.GetComponent<Renderer>().sharedMaterial = material[1];
            ice8.GetComponent<Renderer>().sharedMaterial = material[1];
            ice9.GetComponent<Renderer>().sharedMaterial = material[1];
            ice10.GetComponent<Renderer>().sharedMaterial = material[1];
          
        }
        if (mark == 3)
        {
            ice11.GetComponent<Renderer>().sharedMaterial = material[1];
            ice12.GetComponent<Renderer>().sharedMaterial = material[1];
            ice13.GetComponent<Renderer>().sharedMaterial = material[1];
            ice14.GetComponent<Renderer>().sharedMaterial = material[1];
            ice15.GetComponent<Renderer>().sharedMaterial = material[1];
           
        }

        if (mark == 4)
        {
            ice16.GetComponent<Renderer>().sharedMaterial = material[1];
            ice17.GetComponent<Renderer>().sharedMaterial = material[1];
            ice18.GetComponent<Renderer>().sharedMaterial = material[1];
            ice19.GetComponent<Renderer>().sharedMaterial = material[1];
            ice20.GetComponent<Renderer>().sharedMaterial = material[1];

        }
        if (mark == 5)
        {
            ice21.GetComponent<Renderer>().sharedMaterial = material[1];
            ice22.GetComponent<Renderer>().sharedMaterial = material[1];
            ice23.GetComponent<Renderer>().sharedMaterial = material[1];
            ice24.GetComponent<Renderer>().sharedMaterial = material[1];
            ice25.GetComponent<Renderer>().sharedMaterial = material[1];

        }

        if (mark == 6)
        {
            ice26.GetComponent<Renderer>().sharedMaterial = material[1];
            ice27.GetComponent<Renderer>().sharedMaterial = material[1];
            ice28.GetComponent<Renderer>().sharedMaterial = material[1];
            ice29.GetComponent<Renderer>().sharedMaterial = material[1];
            ice30.GetComponent<Renderer>().sharedMaterial = material[1];

        }
        if (mark == 7)
        {
            ice31.GetComponent<Renderer>().sharedMaterial = material[1];
            ice32.GetComponent<Renderer>().sharedMaterial = material[1];
            ice33.GetComponent<Renderer>().sharedMaterial = material[1];
            ice34.GetComponent<Renderer>().sharedMaterial = material[1];
            ice35.GetComponent<Renderer>().sharedMaterial = material[1];

        }

        if (mark == 8)
        {
            ice26.GetComponent<Renderer>().sharedMaterial = material[1];
            ice21.GetComponent<Renderer>().sharedMaterial = material[1];
            ice17.GetComponent<Renderer>().sharedMaterial = material[1];
            ice12.GetComponent<Renderer>().sharedMaterial = material[1];
            ice8.GetComponent<Renderer>().sharedMaterial = material[1];

        }
        if (mark == 9)
        {
            ice1.GetComponent<Renderer>().sharedMaterial = material[1];
            ice7.GetComponent<Renderer>().sharedMaterial = material[1];
            ice12.GetComponent<Renderer>().sharedMaterial = material[1];
            ice18.GetComponent<Renderer>().sharedMaterial = material[1];
            ice23.GetComponent<Renderer>().sharedMaterial = material[1];
            ice29.GetComponent<Renderer>().sharedMaterial = material[1];

        }


        if (mark == 10)
        {
            ice32.GetComponent<Renderer>().sharedMaterial = material[1];
            ice28.GetComponent<Renderer>().sharedMaterial = material[1];
            ice23.GetComponent<Renderer>().sharedMaterial = material[1];
            ice19.GetComponent<Renderer>().sharedMaterial = material[1];
            ice14.GetComponent<Renderer>().sharedMaterial = material[1];

        }
        if (mark == 11)
        {
            ice3.GetComponent<Renderer>().sharedMaterial = material[1];
            ice9.GetComponent<Renderer>().sharedMaterial = material[1];
            ice14.GetComponent<Renderer>().sharedMaterial = material[1];
            ice20.GetComponent<Renderer>().sharedMaterial = material[1];
            ice25.GetComponent<Renderer>().sharedMaterial = material[1];

        }

        if (mark == 12)
        {
            ice3.GetComponent<Renderer>().sharedMaterial = material[1];
            ice9.GetComponent<Renderer>().sharedMaterial = material[1];
            ice14.GetComponent<Renderer>().sharedMaterial = material[1];
            ice20.GetComponent<Renderer>().sharedMaterial = material[1];
            ice25.GetComponent<Renderer>().sharedMaterial = material[1];

            ice26.GetComponent<Renderer>().sharedMaterial = material[1];
            ice21.GetComponent<Renderer>().sharedMaterial = material[1];
            ice17.GetComponent<Renderer>().sharedMaterial = material[1];
            ice12.GetComponent<Renderer>().sharedMaterial = material[1];
            ice8.GetComponent<Renderer>().sharedMaterial = material[1];

            ice1.GetComponent<Renderer>().sharedMaterial = material[1];
            ice7.GetComponent<Renderer>().sharedMaterial = material[1];
            ice12.GetComponent<Renderer>().sharedMaterial = material[1];
            ice18.GetComponent<Renderer>().sharedMaterial = material[1];
            ice23.GetComponent<Renderer>().sharedMaterial = material[1];
            ice29.GetComponent<Renderer>().sharedMaterial = material[1];

            ice32.GetComponent<Renderer>().sharedMaterial = material[1];
            ice28.GetComponent<Renderer>().sharedMaterial = material[1];
            ice23.GetComponent<Renderer>().sharedMaterial = material[1];
            ice19.GetComponent<Renderer>().sharedMaterial = material[1];
            ice14.GetComponent<Renderer>().sharedMaterial = material[1];

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

            if (time > 0.3)
            {
                mark = 1;
            }

            //觸手上升動畫
            if (time > 0.2)
            {
                ani1.SetBool("up", true);
                ani1.SetBool("normal", false);
                ani1.SetBool("attack", false);
                //Setting = 1;           
            }

            //觸手攻擊動畫
            if (time > 0.7)
            {
                ani1.SetBool("attack", true);
                ani1.SetBool("normal", false);
                ani1.SetBool("up", false);
            }

            //地板消失
            if (time > 1)
            {
                BackGround = 1;
                mark = 0;
            }



            if (time > 1.3)
            {
                BackGround = 0;
            }

            //恢復觸手動畫
            if (time > 1)
            {
                ani1.SetBool("normal", true);
                ani1.SetBool("up", false);
                ani1.SetBool("attack", false);
            }

            //觸手消失
            if (time > 1.5)
            {
                hand1.SetActive(false);
            }

            //進入攻擊2
            if (time > 1.7)
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
            }

            if (time > 0.3)
            {
                mark = 2;
            }

            //觸手上升動畫
            if (time > 0.2)
            {
                ani2.SetBool("up", true);
                ani2.SetBool("normal", false);
                ani2.SetBool("attack", false);
            }

            //觸手攻擊動畫
            if (time > 0.7)
            {
                ani2.SetBool("attack", true);
                ani2.SetBool("normal", false);
                ani2.SetBool("up", false);
            }

            //地板消失
            if (time > 1)
            {
                BackGround = 2;
                mark = 0;
            }



            if (time > 1.3)
            {
                BackGround = 0;
            }

            //恢復觸手動畫
            if (time > 1)
            {
                ani2.SetBool("normal", true);
                ani2.SetBool("up", false);
                ani2.SetBool("attack", false);
            }

            //觸手消失
            if (time > 1.5)
            {
                hand2.SetActive(false);
            }

            //進入攻擊2
            if (time > 1.7)
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
                hand3.SetActive(true);
            }

            if (time > 0.3)
            {
                mark = 3;
            }

            //觸手上升動畫
            if (time > 0.2)
            {
                ani3.SetBool("up", true);
                ani3.SetBool("normal", false);
                ani3.SetBool("attack", false);
            }

            //觸手攻擊動畫
            if (time > 0.7)
            {
                ani3.SetBool("attack", true);
                ani3.SetBool("normal", false);
                ani3.SetBool("up", false);
            }

            //地板消失
            if (time > 1)
            {
                BackGround = 3;
                mark = 0;
            }



            if (time > 1.3)
            {
                BackGround = 0;
            }

            //恢復觸手動畫
            if (time > 1)
            {
                ani3.SetBool("normal", true);
                ani3.SetBool("up", false);
                ani3.SetBool("attack", false);
            }

            //觸手消失
            if (time > 1.5)
            {
                hand3.SetActive(false);
            }

            //進入攻擊2
            if (time > 1.7)
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
                hand4.SetActive(true);
            }

            if (time > 0.3)
            {
                mark = 4;
            }

            //觸手上升動畫
            if (time > 0.2)
            {
                ani4.SetBool("up", true);
                ani4.SetBool("normal", false);
                ani4.SetBool("attack", false);
            }

            //觸手攻擊動畫
            if (time > 0.7)
            {
                ani4.SetBool("attack", true);
                ani4.SetBool("normal", false);
                ani4.SetBool("up", false);
            }

            //地板消失
            if (time > 1)
            {
                BackGround = 4;
                mark = 0;
            }



            if (time > 1.3)
            {
                BackGround = 0;
            }

            //恢復觸手動畫
            if (time > 1)
            {
                ani4.SetBool("normal", true);
                ani4.SetBool("up", false);
                ani4.SetBool("attack", false);
            }

            //觸手消失
            if (time > 1.5)
            {
                hand4.SetActive(false);
            }

            //進入攻擊2
            if (time > 1.7)
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
                hand5.SetActive(true);
            }

            if (time > 0.3)
            {
                mark = 5;
            }

            //觸手上升動畫
            if (time > 0.2)
            {
                ani5.SetBool("up", true);
                ani5.SetBool("normal", false);
                ani5.SetBool("attack", false);
            }

            //觸手攻擊動畫
            if (time > 0.7)
            {
                ani5.SetBool("attack", true);
                ani5.SetBool("normal", false);
                ani5.SetBool("up", false);
            }

            //地板消失
            if (time > 1)
            {
                BackGround = 5;
                mark = 0;
            }



            if (time > 1.3)
            {
                BackGround = 0;
            }

            //恢復觸手動畫
            if (time > 1)
            {
                ani5.SetBool("normal", true);
                ani5.SetBool("up", false);
                ani5.SetBool("attack", false);
            }

            //觸手消失
            if (time > 1.5)
            {
                hand5.SetActive(false);
            }

            //進入攻擊2
            if (time > 1.7)
            {
                levelValue = 6;
                time = 0;
            }

        }

        if (levelValue == 6)
        {
            //觸手出現，標記地板
            if (time > 0)
            {
                hand6.SetActive(true);
            }

            if (time > 0.3)
            {
                mark = 6;
            }

            //觸手上升動畫
            if (time > 0.2)
            {
                ani6.SetBool("up", true);
                ani6.SetBool("normal", false);
                ani6.SetBool("attack", false);
            }

            //觸手攻擊動畫
            if (time > 0.7)
            {
                ani6.SetBool("attack", true);
                ani6.SetBool("normal", false);
                ani6.SetBool("up", false);
            }

            //地板消失
            if (time > 1)
            {
                BackGround = 6;
                mark = 0;
            }



            if (time > 1.3)
            {
                BackGround = 0;
            }

            //恢復觸手動畫
            if (time > 1)
            {
                ani6.SetBool("normal", true);
                ani6.SetBool("up", false);
                ani6.SetBool("attack", false);
            }

            //觸手消失
            if (time > 1.5)
            {
                hand6.SetActive(false);
            }

            //進入攻擊2
            if (time > 1.7)
            {
                levelValue = 7;
                time = 0;
            }

        }

        if (levelValue == 7)
        {
            //觸手出現，標記地板
            if (time > 0)
            {
                hand7.SetActive(true);
            }

            if (time > 0.3)
            {
                mark = 7;
            }

            //觸手上升動畫
            if (time > 0.2)
            {
                ani7.SetBool("up", true);
                ani7.SetBool("normal", false);
                ani7.SetBool("attack", false);
            }

            //觸手攻擊動畫
            if (time > 0.7)
            {
                ani7.SetBool("attack", true);
                ani7.SetBool("normal", false);
                ani7.SetBool("up", false);
            }

            //地板消失
            if (time > 1)
            {
                BackGround = 7;
                mark = 0;
            }



            if (time > 1.3)
            {
                BackGround = 0;
            }

            //恢復觸手動畫
            if (time > 1)
            {
                ani7.SetBool("normal", true);
                ani7.SetBool("up", false);
                ani7.SetBool("attack", false);
            }

            //觸手消失
            if (time > 1.5)
            {
                hand7.SetActive(false);
            }

            //進入攻擊2
            if (time > 1.7)
            {
                levelValue = 8;
                time = 0;
            }

        }

        if (levelValue == 8)
        {
            //觸手出現，標記地板
            if (time > 0)
            {
                hand8.SetActive(true);
            }

            if (time > 0.4)
            {
                mark = 8;
            }

            //觸手上升動畫
            if (time > 0.3)
            {
                ani8.SetBool("up", true);
                ani8.SetBool("normal", false);
                ani8.SetBool("attack", false);
            }

            //觸手攻擊動畫
            if (time > 1.4)
            {
                ani8.SetBool("attack", true);
                ani8.SetBool("normal", false);
                ani8.SetBool("up", false);
            }

            //地板消失
            if (time > 1.6)
            {
                BackGround = 8;
                mark = 0;
            }



            if (time > 2.5)
            {
                BackGround = 0;
            }

            //恢復觸手動畫
            if (time > 1.6)
            {
                ani8.SetBool("normal", true);
                ani8.SetBool("up", false);
                ani8.SetBool("attack", false);
            }

            //觸手消失
            if (time > 3)
            {
                hand8.SetActive(false);
            }

            //進入攻擊2
            if (time > 3.5)
            {
                levelValue = 9;
                time = 0;
            }

        }

        if (levelValue == 9)
        {
            //觸手出現，標記地板
            if (time > 0)
            {
                hand9.SetActive(true);
            }

            if (time > 0.4)
            {
                mark = 9;
            }

            //觸手上升動畫
            if (time > 0.3)
            {
                ani9.SetBool("up", true);
                ani9.SetBool("normal", false);
                ani9.SetBool("attack", false);
            }

            //觸手攻擊動畫
            if (time > 1.4)
            {
                ani9.SetBool("attack", true);
                ani9.SetBool("normal", false);
                ani9.SetBool("up", false);
            }

            //地板消失
            if (time > 1.6)
            {
                BackGround = 9;
                mark = 0;
            }



            if (time > 2.5)
            {
                BackGround = 0;
            }

            //恢復觸手動畫
            if (time > 1.6)
            {
                ani9.SetBool("normal", true);
                ani9.SetBool("up", false);
                ani9.SetBool("attack", false);
            }

            //觸手消失
            if (time > 3)
            {
                hand9.SetActive(false);
            }

            //進入攻擊2
            if (time > 3.5)
            {
                levelValue = 10;
                time = 0;
            }

        }

        if (levelValue == 10)
        {
            //觸手出現，標記地板
            if (time > 0)
            {
                hand10.SetActive(true);
            }

            if (time > 0.4)
            {
                mark = 10;
            }

            //觸手上升動畫
            if (time > 0.3)
            {
                ani10.SetBool("up", true);
                ani10.SetBool("normal", false);
                ani10.SetBool("attack", false);
            }

            //觸手攻擊動畫
            if (time > 1.4)
            {
                ani10.SetBool("attack", true);
                ani10.SetBool("normal", false);
                ani10.SetBool("up", false);
            }

            //地板消失
            if (time > 1.6)
            {
                BackGround = 10;
                mark = 0;
            }



            if (time > 2.5)
            {
                BackGround = 0;
            }

            //恢復觸手動畫
            if (time > 1.6)
            {
                ani10.SetBool("normal", true);
                ani10.SetBool("up", false);
                ani10.SetBool("attack", false);
            }

            //觸手消失
            if (time > 3)
            {
                hand10.SetActive(false);
            }

            //進入攻擊2
            if (time > 3.5)
            {
                levelValue = 11;
                time = 0;
            }

        }


        if (levelValue == 11)
        {
            //觸手出現，標記地板
            if (time > 0)
            {
                hand11.SetActive(true);
            }

            if (time > 0.4)
            {
                mark = 11;
            }

            //觸手上升動畫
            if (time > 0.3)
            {
                ani11.SetBool("up", true);
                ani11.SetBool("normal", false);
                ani11.SetBool("attack", false);
            }

            //觸手攻擊動畫
            if (time > 1.4)
            {
                ani11.SetBool("attack", true);
                ani11.SetBool("normal", false);
                ani11.SetBool("up", false);
            }

            //地板消失
            if (time > 1.6)
            {
                BackGround = 11;
                mark = 0;
            }



            if (time > 2.5)
            {
                BackGround = 0;
            }

            //恢復觸手動畫
            if (time > 1.6)
            {
                ani11.SetBool("normal", true);
                ani11.SetBool("up", false);
                ani11.SetBool("attack", false);
            }

            //觸手消失
            if (time > 3)
            {
                hand11.SetActive(false);
            }

            //進入攻擊2
            if (time > 3.5)
            {
                levelValue = 12;
                time = 0;
            }

        }

        if (levelValue == 12)
        {
            //觸手出現，標記地板
            if (time > 0)
            {
                hand8.SetActive(true);
                hand9.SetActive(true);
                hand10.SetActive(true);
                hand11.SetActive(true);
            }

            if (time > 0.4)
            {
                mark = 12;
            }

            //觸手上升動畫
            if (time > 0.3)
            {
                ani8.SetBool("up", true);
                ani8.SetBool("normal", false);
                ani8.SetBool("attack", false);

                ani9.SetBool("up", true);
                ani9.SetBool("normal", false);
                ani9.SetBool("attack", false);

                ani10.SetBool("up", true);
                ani10.SetBool("normal", false);
                ani10.SetBool("attack", false);

                ani11.SetBool("up", true);
                ani11.SetBool("normal", false);
                ani11.SetBool("attack", false);
            }

            //觸手攻擊動畫
            if (time > 1.4)
            {
                ani8.SetBool("attack", true);
                ani8.SetBool("normal", false);
                ani8.SetBool("up", false);

                ani9.SetBool("attack", true);
                ani9.SetBool("normal", false);
                ani9.SetBool("up", false);

                ani10.SetBool("attack", true);
                ani10.SetBool("normal", false);
                ani10.SetBool("up", false);

                ani11.SetBool("attack", true);
                ani11.SetBool("normal", false);
                ani11.SetBool("up", false);
            }

            //地板消失
            if (time > 1.6)
            {
                BackGround = 12;
                mark = 0;
            }



            //if (time > 2.5)
            //{
             //   BackGround = 0;
            //}

            //恢復觸手動畫
            if (time > 1.6)
            {
                ani8.SetBool("normal", true);
                ani8.SetBool("up", false);
                ani8.SetBool("attack", false);

                ani9.SetBool("normal", true);
                ani9.SetBool("up", false);
                ani9.SetBool("attack", false);

                ani10.SetBool("normal", true);
                ani10.SetBool("up", false);
                ani10.SetBool("attack", false);

                ani11.SetBool("normal", true);
                ani11.SetBool("up", false);
                ani11.SetBool("attack", false);
            }

            //觸手消失
            if (time > 3)
            {
                hand8.SetActive(false);
                hand9.SetActive(false);
                hand10.SetActive(false);
                hand11.SetActive(false);
            }

            //進入攻擊2
            if (time > 3)
            {
                levelValue = 13;
                time = 0;
            }

        }


        if (levelValue == 13)
        {
            //觸手出現，標記地板
            if (time > 0)
            {
                hand1.SetActive(true);
            }

            if (time > 0.4)
            {
                mark = 1;
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



           // if (time > 1.3)
            //{
            //    BackGround = 0;
          //  }

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
                levelValue = 14;
                time = 0;
            }

        }

        if (levelValue == 15)
        {
            //觸手出現，標記地板
            if (time > 0)
            {
                hand2.SetActive(true);
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
            }

            //觸手攻擊動畫
            if (time > 1.4)
            {
                ani2.SetBool("attack", true);
                ani2.SetBool("normal", false);
                ani2.SetBool("up", false);
            }

            //地板消失
            if (time > 1.6)
            {
                BackGround = 2;
                mark = 0;
            }



          //  if (time > 1.3)
         //   {
            //    BackGround = 0;
           // }

            //恢復觸手動畫
            if (time > 1.6)
            {
                ani2.SetBool("normal", true);
                ani2.SetBool("up", false);
                ani2.SetBool("attack", false);
            }

            //觸手消失
            if (time > 3)
            {
                hand2.SetActive(false);
            }

            //進入攻擊2
            if (time > 3.5)
            {
                levelValue = 16;
                time = 0;
            }

        }

        if (levelValue == 17)
        {
            //觸手出現，標記地板
            if (time > 0)
            {
                hand3.SetActive(true);
            }

            if (time > 0.4)
            {
                mark = 3;
            }

            //觸手上升動畫
            if (time > 0.3)
            {
                ani3.SetBool("up", true);
                ani3.SetBool("normal", false);
                ani3.SetBool("attack", false);
            }

            //觸手攻擊動畫
            if (time > 1.4)
            {
                ani3.SetBool("attack", true);
                ani3.SetBool("normal", false);
                ani3.SetBool("up", false);
            }

            //地板消失
            if (time > 1.6)
            {
                BackGround = 3;
                mark = 0;
            }



           // if (time > 1.3)
           // {
           //     BackGround = 0;
           // }

            //恢復觸手動畫
            if (time > 1.6)
            {
                ani3.SetBool("normal", true);
                ani3.SetBool("up", false);
                ani3.SetBool("attack", false);
            }

            //觸手消失
            if (time > 3)
            {
                hand3.SetActive(false);
            }

            //進入攻擊2
            if (time > 3.5)
            {
                levelValue = 18;
                time = 0;
            }

        }

       

        if (levelValue == 18)
        {
            //觸手出現，標記地板
            if (time > 0)
            {
                hand5.SetActive(true);
            }

            if (time > 0.4)
            {
                mark = 5;
            }

            //觸手上升動畫
            if (time > 0.3)
            {
                ani5.SetBool("up", true);
                ani5.SetBool("normal", false);
                ani5.SetBool("attack", false);
            }

            //觸手攻擊動畫
            if (time > 1.4)
            {
                ani5.SetBool("attack", true);
                ani5.SetBool("normal", false);
                ani5.SetBool("up", false);
            }

            //地板消失
            if (time > 1.6)
            {
                BackGround = 5;
                mark = 0;
            }



           // if (time > 1.3)
          //  {
          //      BackGround = 0;
           // }

            //恢復觸手動畫
            if (time > 1.6)
            {
                ani5.SetBool("normal", true);
                ani5.SetBool("up", false);
                ani5.SetBool("attack", false);
            }

            //觸手消失
            if (time > 3)
            {
                hand5.SetActive(false);
            }

            //進入攻擊2
            if (time > 3.5)
            {
                levelValue = 19;
                time = 0;
            }

        }

        if (levelValue == 16)
        {
            //觸手出現，標記地板
            if (time > 0)
            {
                hand6.SetActive(true);
            }

            if (time > 0.4)
            {
                mark = 6;
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
            if (time > 1.6)
            {
                BackGround = 6;
                mark = 0;
            }



         //   if (time > 1.3)
         //   {
         //       BackGround = 0;
           // }

            //恢復觸手動畫
            if (time > 1.6)
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
                levelValue = 17;
                time = 0;
            }

        }

        if (levelValue == 14)
        {
            //觸手出現，標記地板
            if (time > 0)
            {
                hand7.SetActive(true);
            }

            if (time > 0.4)
            {
                mark = 7;
            }

            //觸手上升動畫
            if (time > 0.3)
            {
                ani7.SetBool("up", true);
                ani7.SetBool("normal", false);
                ani7.SetBool("attack", false);
            }

            //觸手攻擊動畫
            if (time > 1.4)
            {
                ani7.SetBool("attack", true);
                ani7.SetBool("normal", false);
                ani7.SetBool("up", false);
            }

            //地板消失
            if (time > 1.6)
            {
                BackGround = 7;
                mark = 0;
            }



          //  if (time > 1.3)
          //  {
           //     BackGround = 0;
           // }

            //恢復觸手動畫
            if (time > 1.6)
            {
                ani7.SetBool("normal", true);
                ani7.SetBool("up", false);
                ani7.SetBool("attack", false);
            }

            //觸手消失
            if (time > 3)
            {
                hand7.SetActive(false);
            }

            //進入攻擊2
            if (time > 3.5)
            {
                levelValue = 15;
                time = 0;
            }

        }



        if (levelValue == 19)
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
                if (BossHp.WhatLevelNow == 7)
                {
                    levelValue = 7;
                    time = 0;

                    ax.SetActive(false);




                }
                else if (BossHp.WhatLevelNow == 6)
                {
                    levelValue = 1;
                    BackGround = 0;
                    time = 0;

                    ax.SetActive(false);

                }
            }

        }
    }
}

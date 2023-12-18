using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack3 : MonoBehaviour
{
    [Header("hand")]
    public GameObject hand1;
    public GameObject hand2;
    public GameObject hand3;
    public GameObject hand4;
    public GameObject hand5;
    public GameObject handL;

    [Header("value")]
    public static int SetAni;
    public float time;
    public static int WhichAttack;
    public static int Mark;
    public static int AttackValue;




    // Start is called before the first frame update
    void Start()
    {

        if (findHand2.EndInt == 3)
        {
            time -= Time.time;
        }

        hand1.SetActive(false);
        hand2.SetActive(false);
        hand3.SetActive(false);
        hand4.SetActive(false);
        hand5.SetActive(false);
        handL.SetActive(false);
        SetAni = 0;
        AttackValue = 9;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(WhichAttack);

        if (WhichAttack == 0)
        {
            hand1.SetActive(false);
            hand2.SetActive(false);
            hand3.SetActive(false);
            hand4.SetActive(false);
            hand5.SetActive(false);
            handL.SetActive(false);
        }

        if (WhichAttack == 9)
        {
            hand1.SetActive(true);

            // AttackValue = 2;
            SetAni = 1;
        }
        else
        {
            hand1.SetActive(false);
        }

        if (WhichAttack == 10)
        {
            hand2.SetActive(true);
            hand3.SetActive(true);

            //  AttackValue= 3;
            SetAni = 1;
        }
        else
        {
            hand2.SetActive(false);
            hand3.SetActive(false);
        }

        if (WhichAttack == 11)
        {
            hand4.SetActive(true);
            hand5.SetActive(true);

            //  AttackValue = 4;
            SetAni = 1;
        }
        else
        {
            hand4.SetActive(false);
            hand5.SetActive(false);
        }

        
        if (WhichAttack == 5)
        {
            handL.SetActive(true);

            SetAni = 1;
        }
        else
        {
            handL.SetActive(false);
        }


        if (SetAni == 2)
        {
            time = 3;
        }


        if (time == 3 && IceBack3.IceGoBack == 1)
        {
            SetAni = 0;
            Mark = 0;
            Debug.Log(IceBack3.IceGoBack);
        }

        if (SetAni == 0 && AttackValue != 0)
        {
            time -= Time.deltaTime;

        }

        if (time < 0)
        {
            IceBack3.IceGoBack = 0;
            if (AttackValue == 9)
            {
                WhichAttack = 9;
                Mark = 9;
            }
        }

        if (IceBack3.IceGoBack == 1)
        {
           
            if (AttackValue == 10)
            {
                WhichAttack = 10;
                Mark = 10;
            }
            if (AttackValue == 11)
            {
                WhichAttack =11;
                Mark = 11;
            }

            if (AttackValue == 5)
            {
                WhichAttack = 5;
            }
        }

    }
}

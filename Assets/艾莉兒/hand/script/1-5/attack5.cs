using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack5 : MonoBehaviour
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

        time = 1;

        AttackValue = 1;
        WhichAttack = -1;

        hand1.SetActive(false);
        hand2.SetActive(false);
        hand3.SetActive(false);
        hand4.SetActive(false);
        hand5.SetActive(false);
        handL.SetActive(false);
        SetAni = -1;
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

        if (WhichAttack == 1)
        {
            hand1.SetActive(true);

            // AttackValue = 2;
            SetAni = 1;
        }
        else
        {
            hand1.SetActive(false);
        }

        if (WhichAttack == 2)
        {
            hand3.SetActive(true);

            //  AttackValue= 3;
            SetAni = 1;
        }
        else
        {
            hand3.SetActive(false);
        }

        if (WhichAttack == 3)
        {
            hand5.SetActive(true);

            //  AttackValue = 4;
            SetAni = 1;
        }
        else
        {
            hand5.SetActive(false);
        }

        if (WhichAttack == 4)
        {
            hand2.SetActive(true);
            hand4.SetActive(true);

            // AttackValue = 0;
            SetAni = 1;
        }
        else
        {
            hand2.SetActive(false);
            hand4.SetActive(false);
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


        if (time == 3 && IceBack.IceGoBack == 1)
        {
            SetAni = 0;
            Mark = 0;
            Debug.Log(IceBack.IceGoBack);
        }

        if (SetAni == 0 && AttackValue != 0)
        {
            time -= Time.deltaTime;

        }

        if (time < 0)
        {
            IceBack.IceGoBack = 0;
            if (AttackValue == 1)
            {
                WhichAttack = 1;
                Mark = 1;
            }
        }

        if (IceBack.IceGoBack == 1)
        {
            if (AttackValue == 2)
            {
                WhichAttack = 2;
                Mark = 2;
            }
            if (AttackValue == 3)
            {
                WhichAttack = 3;
                Mark = 3;
            }
            if (AttackValue == 4)
            {
                WhichAttack = 4;
                Mark = 4;
            }

            if (AttackValue == 5)
            {
                WhichAttack = 5;
            }
        }

    }
}

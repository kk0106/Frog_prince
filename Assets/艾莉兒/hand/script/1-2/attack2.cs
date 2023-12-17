using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack2 : MonoBehaviour
{
    [Header("hand")]
    public GameObject hand1;
    public GameObject hand2;
    public GameObject hand3;
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
        if(findHand.EndInt==2)
        {
            time -= Time.time;
        }

        hand1.SetActive(false);
        hand2.SetActive(false);
        hand3.SetActive(false);
 
        handL.SetActive(false);
        SetAni =0;
        AttackValue =6;
     
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
     
            handL.SetActive(false);
        }

        if (WhichAttack == 6)
        {
            hand1.SetActive(true);

            // AttackValue = 2;
          SetAni = 1;
        }
        else
        {
            hand1.SetActive(false);
        }

        if (WhichAttack == 7)
        {
            hand2.SetActive(true);

            //  AttackValue= 3;
              SetAni = 1;
        }
        else
        {
            hand2.SetActive(false);
        }

        if (WhichAttack == 8)
        {

            hand3.SetActive(true);
            //  AttackValue = 4;
       SetAni = 1;
        }
        else
        {
            hand3.SetActive(false);
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


        if (time == 3 && IceBack2.IceGoBack == 1)
        {
            SetAni = 0;
            Mark = 0;
            Debug.Log(IceBack2.IceGoBack);
        }

        if (SetAni == 0 && AttackValue != 0)
        {
            time -= Time.deltaTime;

        }

        if (time < 0)
        {
            IceBack2.IceGoBack = 0;
            if (AttackValue == 6)
            {
                WhichAttack = 6;
                Mark = 6;
            }
        }

        if (IceBack2.IceGoBack == 1)
        {
            
            if (AttackValue == 7)
            {
                WhichAttack = 7;
                Mark = 7;
            }
            if (AttackValue == 8)
            {
                WhichAttack = 8;
                Mark = 8;
            }
            

            if (AttackValue == 5)
            {
                WhichAttack = 5;
            }
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack4 : MonoBehaviour
{
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

        if (findHand3.EndInt == 4)
        {
            time -= Time.time;
        }
        

        AttackValue = 12;
       

        hand1.SetActive(false);
        hand2.SetActive(false);
        hand3.SetActive(false);
        hand4.SetActive(false);
        hand5.SetActive(false);
        hand6.SetActive(false);
        hand7.SetActive(false);
        hand8.SetActive(false);
        hand9.SetActive(false);
        handL.SetActive(false);
        SetAni = 0;
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
            hand6.SetActive(false);
            hand7.SetActive(false);
            hand8.SetActive(false);
            hand9.SetActive(false);
            handL.SetActive(false);
        }

        if (WhichAttack == 12)
        {
            hand1.SetActive(true);
            hand2.SetActive(true);
            hand3.SetActive(true);

            // AttackValue = 2;
            SetAni = 1;
        }
        else
        {
            hand1.SetActive(false);
            hand2.SetActive(false);
            hand3.SetActive(false);
        }

        if (WhichAttack == 13)
        {
            hand6.SetActive(true);
            hand4.SetActive(true);
            hand5.SetActive(true);

            //  AttackValue= 3;
            SetAni = 1;
        }
        else
        {
            hand6.SetActive(false);
            hand4.SetActive(false);
            hand5.SetActive(false);
        }

        if (WhichAttack == 14)
        {
          
            hand3.SetActive(true);
            hand7.SetActive(true);
            hand8.SetActive(true);
            hand9.SetActive(true);

            //  AttackValue = 4;
            SetAni = 1;
        }
        else
        {
          
            hand3.SetActive(false);
            hand7.SetActive(false);
            hand8.SetActive(false);
            hand9.SetActive(false);

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


        if (time == 3 && IceBack4.IceGoBack == 1)
        {
            SetAni = 0;
            Mark = 0;
            Debug.Log(IceBack4.IceGoBack);
        }

        if (SetAni == 0 && AttackValue != 0)
        {
            time -= Time.deltaTime;

        }

        if (time < 0)
        {
            IceBack4.IceGoBack = 0;
            if (AttackValue == 12)
            {
                WhichAttack = 12;
                Mark = 12;
            }
        }

        if (IceBack4.IceGoBack == 1)
        {
            if (AttackValue == 13)
            {
                WhichAttack = 13;
                Mark = 13;
            }
            if (AttackValue == 14)
            {
                WhichAttack = 14;
                Mark = 14;
            }
        

            if (AttackValue == 5)
            {
                WhichAttack = 5;
            }
        }

    }
}

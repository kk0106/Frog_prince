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
    public GameObject hand6;   
    public GameObject hand7;
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

        if (findHand4.EndInt == 5)
        {
            time -= Time.time;
        }


        AttackValue = 15;
        SetAni = 0;

        hand1.SetActive(false);
        hand2.SetActive(false);
        hand3.SetActive(false);
        hand4.SetActive(false);
        hand5.SetActive(false);
        hand6.SetActive(false);
        hand7.SetActive(false);
        handL.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(WhichAttack);


        if(WhichAttack==15||WhichAttack==16||WhichAttack==17)
        {
            if(WhichAttack==15)
            {
                hand2.SetActive(true);
                hand5 .SetActive(false);
                SetAni = 1;
            }

            if(WhichAttack==16)
            {
                hand5.SetActive(true);
                hand2.SetActive(false);
                SetAni = 1;
            }

            if (WhichAttack == 17)
            {
                hand2.SetActive(true);
                hand5.SetActive(true);
                SetAni = 1;
            }
        }
        else
        {
            hand2.SetActive (false);
            hand5.SetActive (false);
        }

        if (WhichAttack == 0)
        {
            hand1.SetActive(false);
            hand2.SetActive(false);
            hand3.SetActive(false);
            hand4.SetActive(false);
            hand5.SetActive(false);
            hand6.SetActive(false);
            hand7.SetActive(false);
            handL.SetActive(false);
        }

        if (WhichAttack == 15)
        {
            hand1.SetActive(true);
           // hand2.SetActive(true);
            hand3.SetActive(true);

            // AttackValue = 2;
            SetAni = 1;
        }
        else
        {
            hand1.SetActive(false);
            //hand2.SetActive(false);
            hand3.SetActive(false);
        }

        
        if (WhichAttack == 16)
        {
            hand6.SetActive(true);
            hand4.SetActive(true);
           // hand5.SetActive(true);
                

            //  AttackValue= 3;
            SetAni = 1;
        }
        else
        {
            hand4.SetActive(false);
           // hand5.SetActive(false);
            hand6.SetActive(false);
        }

        if (WhichAttack == 17)
        {
           // hand2.SetActive(true);
          //  hand5.SetActive(true);
            hand7.SetActive(true);

            //  AttackValue = 4;
            SetAni = 1;
        }
        else
        {
           // hand2.SetActive(false);
           // hand5.SetActive(false);
            hand7.SetActive(false);
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


        if (time == 3 && IceBack5.IceGoBack == 1)
        {
            SetAni = 0;
            Mark = 0;
            Debug.Log(IceBack5.IceGoBack);
        }

        if (SetAni == 0 && AttackValue != 0)
        {
            time -= Time.deltaTime;

        }

        if (time < 0)
        {
            IceBack5.IceGoBack = 0;
            if (AttackValue == 15)
            {
                WhichAttack = 15;
                Mark = 15;
            }
        }

        if (IceBack5.IceGoBack == 1)
        {
            if (AttackValue == 16)
            {
                WhichAttack = 16;
                Mark = 16;
            }
            if (AttackValue == 17)
            {
                WhichAttack = 17;
                Mark = 17;
            }
            
            if (AttackValue == 5)
            {
                WhichAttack = 5;
            }
        }

    }
}

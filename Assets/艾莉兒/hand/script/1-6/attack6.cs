using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack6 : MonoBehaviour
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
    public GameObject hand10;
    public GameObject hand11;

    [Header("value")]
    public static int SetAni;
    public float time;
    public static int WhichAttack;
    public static int Mark;
    public static int AttackValue;




    // Start is called before the first frame update
    void Start()
    {

        if (findHand5.EndInt == 6)
        {
            time -= Time.time;
        }


        AttackValue = 18;
        SetAni = 0;

        hand1.SetActive(false);
        hand2.SetActive(false);
        hand3.SetActive(false);
        hand4.SetActive(false);
        hand5.SetActive(false);
        hand6.SetActive(false);
        hand7.SetActive(false);
        hand8.SetActive(false);
        hand9.SetActive(false);
        hand10.SetActive(false);
        hand11.SetActive(false);
   
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
            hand10.SetActive(false);
            hand11.SetActive (false);
            
        }

        if (WhichAttack == 18)
        {
            hand1.SetActive(true);
            SetAni = 1;
        }
        

        if (WhichAttack == 19)
        {
            hand2.SetActive(true);
            SetAni = 1;
        }
        

        if (WhichAttack == 20)
        {
            hand3.SetActive(true);
            SetAni = 1;
        }
        
        if (WhichAttack == 21)
        {
            hand4.SetActive(true);
            SetAni = 1;
        }
        

        if (WhichAttack == 22)
        {
            hand5.SetActive(true);
            SetAni = 1;
        }
        else
        {
            hand5.SetActive(false);
        }


        if (WhichAttack == 23)
        {
            hand6.SetActive(true);
            SetAni = 1;
        }
        else
        {
            hand6.SetActive(false);
        }

        if (WhichAttack == 24)
        {
            hand7.SetActive(true);
            SetAni = 1;
        }
        else
        {
            hand7.SetActive(false);
        }


        if (WhichAttack == 25)
        {
            hand8.SetActive(true);
            SetAni = 1;
        }
        else
        {
            hand8.SetActive(false);
        }

        if (WhichAttack == 26)
        {
            hand9.SetActive(true);
            SetAni = 1;
        }
        else
        {
            hand9.SetActive(false);
        }

        if (WhichAttack == 27)
        {
            hand10.SetActive(true);
            SetAni = 1;
        }
        else
        {
            hand10.SetActive(false);
        }
        if (WhichAttack == 28)
        {
            hand11.SetActive(true);
            SetAni = 1;
        }
        else
        {
            hand11.SetActive(false);
        }


        if (SetAni == 2)
        {
            time = 3;
        }


        if (time == 3 && IceBack6.IceGoBack == 1)
        {
            SetAni = 0;
            Mark = 0;
            Debug.Log(IceBack6.IceGoBack);
        }

        if (SetAni == 0 && AttackValue != 0)
        {
            time -= Time.deltaTime;

        }

        if (time < 0)
        {
            IceBack6.IceGoBack = 0;
            if (AttackValue == 18)
            {
                WhichAttack = 18;
                Mark = 18;
            }
        }

        if (IceBack6.IceGoBack == 1)
        {
            if (AttackValue == 19)
            {
                WhichAttack = 19;
                Mark = 19;
            }
            if (AttackValue == 20)
            {
                WhichAttack = 20;
                Mark = 20;
            }
            if (AttackValue == 21)
            {
                WhichAttack = 21;
                Mark = 21;
            }

            if (AttackValue == 22)
            {
                WhichAttack =22;
                Mark = 22;
            }
            if (AttackValue == 23)
            {
                WhichAttack = 23;
                Mark = 23;
            }
            if (AttackValue == 24)
            {
                WhichAttack = 24;
                Mark = 24;
            }
            if (AttackValue == 25)
            {
                WhichAttack = 25;
                Mark = 25;
            }

            if (AttackValue == 26)
            {
                WhichAttack = 26;
                Mark = 26;
            }
            if (AttackValue == 27)
            {
                WhichAttack = 27;
                Mark = 27;
            }
            if (AttackValue == 28)
            {
                WhichAttack = 28;
                Mark = 28;
            }
        }

    }
}

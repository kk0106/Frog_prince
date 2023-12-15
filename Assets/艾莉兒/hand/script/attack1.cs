using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack1 : MonoBehaviour
{
    [Header("hand")]
    public GameObject hand1;
    public GameObject hand2;
    public GameObject hand3;
    public GameObject hand4;
    public GameObject hand5;

    [Header("value")]
    public static int SetAni;
    public float time;
    public static int WhichAttack;
    public static int Mark;
    public static int AttackValue;
   

  
  
    // Start is called before the first frame update
    void Start()
    {
 
   
        AttackValue = 1;

        hand1.SetActive(false);
        hand2.SetActive(false);
        hand3.SetActive(false);
        hand4.SetActive(false);
        hand5.SetActive(false);

        SetAni = -1;
    }

    // Update is called once per frame
    void Update()
    {
        if (WhichAttack == 0)
        {
            hand1.SetActive(false);
            hand2.SetActive(false);
            hand3.SetActive(false);
            hand4.SetActive(false);
            hand5.SetActive(false);
        }

        if(WhichAttack == 1)
        {
            hand1 .SetActive(true);

            AttackValue = 2;
            SetAni = 1;
        }
        if(WhichAttack == 2)
        {
            hand3 .SetActive(true);

            AttackValue= 3;
            SetAni = 1;
        }
        if(WhichAttack == 3)
        {
            hand5 .SetActive(true);

            AttackValue = 4;
            SetAni = 1;
        }
        if(WhichAttack == 4)
        {
            hand2 .SetActive(true);
            hand4 .SetActive(true);

            AttackValue = 0;
            SetAni = 1;
        }

        if (SetAni == 2 )
        {
            
            Mark = 0;

            time = 5;
        }

       
       
       if(time==5)
        {
            SetAni = 0;
        }

        if (SetAni == 0)
        {
            time-=Time.deltaTime;
        }

        if (time < 0)
        {
            if (AttackValue == 1)
            {
                WhichAttack = 1;
            }
        }

        
    }
}

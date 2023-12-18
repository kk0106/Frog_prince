using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class findHand6 : MonoBehaviour
{
    public static float time;
    public GameObject hand;
    public GameObject hand1;
    public GameObject hand2;
    public GameObject hand3;
    public GameObject hand4;
    public GameObject hand5;
    public GameObject hand6;
    public GameObject hand7;
    public GameObject hand8;
    public static int EndInt;

    // Start is called before the first frame update
    void Start()
    {
        EndInt = 0;
        time = 7;
    }

    // Update is called once per frame
    void Update()
    {
        if (hand.activeInHierarchy || hand1.activeInHierarchy || hand2.activeInHierarchy||
            hand3.activeInHierarchy || hand4.activeInHierarchy || hand5.activeInHierarchy||
            hand6.activeInHierarchy  )
        {
            time -= Time.deltaTime;
        }

        if (time < 4)
        {
            attack6.WhichAttack = 18;
        }
        if (time < 3)
        {
            attack6.WhichAttack = 19;
        }
        if (time < 2)
        {
            attack6.WhichAttack = 20;
        }
        if (time < 1)
        {
            attack6.WhichAttack = 21;
        }
        if (time < 0)
        {
            attack6.WhichAttack = 22;
        }
                  
        if (time < -9.5f)
        {
            attack6.AttackValue = 0;

            EndInt = 1;
            Debug.Log(EndInt);
        }

        Debug.Log(time);
    }
}

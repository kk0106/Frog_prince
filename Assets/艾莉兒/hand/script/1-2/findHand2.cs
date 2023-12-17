using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class findHand2 : MonoBehaviour
{
    public static float time;
    public GameObject hand;
    public GameObject hand1;
    public GameObject hand2;
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
        if (hand.activeInHierarchy || hand1.activeInHierarchy || hand2.activeInHierarchy || attack1.AttackValue == 4 || attack1.WhichAttack == 5)
        {
            time -= Time.deltaTime;
        }

        if (time < 3.8)
        {

            attack1.AttackValue = 7;
            // time = 7;
        }
        if (time < 0.6)
        {
            attack1.AttackValue = 8;
        }
        if (time < -5.2)
        {
            attack1.AttackValue = -1;
        }
        if (time < -9.5f)
        {
            attack1.AttackValue = 0;

            EndInt = 1;
            Debug.Log(EndInt);
        }

        Debug.Log(time);
    }
}

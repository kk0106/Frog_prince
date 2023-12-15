using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class findHand : MonoBehaviour
{
    public float time;
    public GameObject hand;
    public GameObject hand1;
    public GameObject hand2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hand.activeInHierarchy||hand1.activeInHierarchy||hand2.activeInHierarchy)
        {
            time-=Time.deltaTime;
        }

        if (time < 0.9f)
        {
            attack1.AttackValue = 2;
           // time = 7;
        }
        if (time < -5.21f)
        {
            attack1.AttackValue = 3;
        }
        if (time < -11.6f)
        {
            attack1.AttackValue = 4;
        }

    }
}

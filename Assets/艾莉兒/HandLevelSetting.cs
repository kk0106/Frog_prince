using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandLevelSetting : MonoBehaviour
{
    public int whatlevel;
    public GameObject blood5;
    public GameObject blood4;
    public GameObject level1;
    public GameObject level2;
    public GameObject level3;

    // Start is called before the first frame update
    void Start()
    {
        whatlevel = 1;
        level2.SetActive(false);
        level3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(blood5.activeInHierarchy)
        {
            level1.SetActive(false);
            whatlevel = 2;
        }
        if (findHand.EndInt == 1 && whatlevel == 1)
        {
            attack1.WhichAttack = 1;
            attack1.AttackValue = 1;
            findHand.time = 7;
            findHand.EndInt = 0;
        }

        if (whatlevel == 2)
        {
            level2.SetActive(true);
            findHand.EndInt = 2;
        }

        if (blood4.activeInHierarchy)
        {
            level2.SetActive(false);
            whatlevel = 3;
        }
        if (findHand2.EndInt == 1 && whatlevel == 2)
        {
            attack2.WhichAttack = 6;
            attack2.AttackValue = 6;
            findHand2.time = 7;
            findHand2.EndInt = 0;
        }

        if (whatlevel == 3)
        {
            level3.SetActive(true);
            findHand2.EndInt = 2;
        }
    }
}

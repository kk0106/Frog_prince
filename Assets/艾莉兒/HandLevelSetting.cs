using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandLevelSetting : MonoBehaviour
{
    public int whatlevel;
    public GameObject blood5;
    public GameObject level1;
    public GameObject level2;
    // Start is called before the first frame update
    void Start()
    {
        whatlevel = 1;
        level2.SetActive(false);
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
        }
    }
}

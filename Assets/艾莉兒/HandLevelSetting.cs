using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandLevelSetting : MonoBehaviour
{
    public int whatlevel;
    public GameObject blood5;
    public GameObject blood4;
    public GameObject blood3;

    public GameObject level1;
    public GameObject level2;
    public GameObject level3;
    public GameObject level4;

    // Start is called before the first frame update
    void Start()
    {
        whatlevel = 1;
        level2.SetActive(false);
        level3.SetActive(false);
        level4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       // �Ĥ@���q��
        if(blood5.activeInHierarchy)
        {
            level1.SetActive(false);
            whatlevel = 2;
        }
        if (whatlevel == 2)
        {
            level2.SetActive(true);
            findHand.EndInt = 2;
        }
        //�Ĥ@���S�L����
        if (findHand.EndInt == 1 && whatlevel == 1)
        {
            attack1.WhichAttack = 1;
            attack1.AttackValue = 1;
            findHand.time = 7;
            findHand.EndInt = 0;
        }


        // �ĤG���q��
        if (blood4.activeInHierarchy)
        {
            level2.SetActive(false);
            whatlevel = 3;
        }
        if (whatlevel == 3)
        {
            level3.SetActive(true);
            findHand2.EndInt = 3;
        }
        //�ĤG���S�L����
        if (findHand2.EndInt == 1 && whatlevel == 2)
        {
            attack2.WhichAttack = 6;
            attack2.AttackValue = 6;
            findHand2.time = 7;
            findHand2.EndInt = 0;
        }

        // �ĤT���q��
       if (blood3.activeInHierarchy)
        {
            level3.SetActive(false);
            whatlevel = 4;
        }
        if (whatlevel == 4)
        {
            level4.SetActive(true);
            findHand3.EndInt = 4;
        }
     
        //�ĤT���S�L����
        if (findHand3.EndInt == 1 && whatlevel == 3)
        {
            attack3.WhichAttack = 9;
            attack3.AttackValue = 9;
            findHand3.time = 7;
            findHand3.EndInt = 0;
        }
    }
}

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
    public GameObject blood2;
    public GameObject blood1;
    public GameObject blood0;

    public GameObject level1;
    public GameObject level2;
    public GameObject level3;
    public GameObject level4;
    public GameObject level5;
    public GameObject level6;

    // Start is called before the first frame update
    void Start()
    {
        whatlevel = 1;
        level2.SetActive(false);
        level3.SetActive(false);
        level4.SetActive(false);
        level5.SetActive(false);
        level6.SetActive(false);

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

        //�ĥ|���S�L����
        if (findHand4.EndInt == 1 && whatlevel == 4)
        {
            attack4.WhichAttack = 12;
            attack4.AttackValue = 12;
            findHand4.time = 7;
            findHand4.EndInt = 0;
        }
        // �ĥ|���q��
        if (blood2.activeInHierarchy)
        {
            level4.SetActive(false);
            whatlevel = 5;
        }
        if (whatlevel == 5)
        {
            level5.SetActive(true);
            findHand4.EndInt = 5;
        }

        //�Ĥ����S�L����
        if (findHand5.EndInt == 1 && whatlevel == 5)
        {
            attack5.WhichAttack = 15;
            attack5.AttackValue = 15;
            findHand5.time = 7;
            findHand5.EndInt = 0;
        }
         // �Ĥ����q��
         if (blood1.activeInHierarchy)
         {
             level5.SetActive(false);
             whatlevel = 6;
         }
         if (whatlevel == 6)
         {
             level6.SetActive(true);
             findHand5.EndInt = 6;
         }

         //�Ĥ����S�L����
         if (findHand6.EndInt == 1 && whatlevel == 6)
         {
             attack6.WhichAttack = 18;
             attack6.AttackValue = 18;
             findHand6.time = 7;
             findHand6.EndInt = 0;
         }
         // �Ĥ����q��
         if (blood0.activeInHierarchy)
         {
             level6.SetActive(false);
             whatlevel = 7;
         }
         if (whatlevel == 6)
         {

             findHand6.EndInt = 7;
         }
    }
}

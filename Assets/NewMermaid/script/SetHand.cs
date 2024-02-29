using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetHand : MonoBehaviour
{
    public GameObject level1;
    public GameObject level2;
    public GameObject level3;
    public GameObject level4;
    public GameObject level5;
    public GameObject level6;

    public GameObject godness;

    // Start is called before the first frame update
    void Start()
    {
        level1.SetActive(false);
        level2.SetActive(false);
        level3.SetActive(false);
        level4.SetActive(false);
        level5.SetActive(false);
        level6.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       if(godness.activeInHierarchy)
        {
            level1.SetActive(false);
            level2.SetActive(false);
            level3.SetActive(false);
            level4.SetActive(false);
            level5.SetActive(false);
            level6.SetActive(false);
        }

        if (BossHp.WhatLevelNow == 1)
        {
            level1.SetActive(true);
            level2.SetActive(false);
            level3.SetActive(false);
            level4.SetActive(false);
            level5.SetActive(false);
            level6.SetActive(false);
        }

        if (BossHp.WhatLevelNow == 2)
        {
            level1.SetActive(false);
            level2.SetActive(true);
            level3.SetActive(false);
            level4.SetActive(false);
            level5.SetActive(false);
            level6.SetActive(false);
        }


        if (BossHp.WhatLevelNow == 3)
        {
            level1.SetActive(false);
            level2.SetActive(false);
            level3.SetActive(true);
            level4.SetActive(false);
            level5.SetActive(false);
            level6.SetActive(false);
        }


        if (BossHp.WhatLevelNow == 4)
        {
            level1.SetActive(false);
            level2.SetActive(false);
            level3.SetActive(false);
            level4.SetActive(true);
            level5.SetActive(false);
            level6.SetActive(false);
        }

        if (BossHp.WhatLevelNow == 5)
        {
            level1.SetActive(false);
            level2.SetActive(false);
            level3.SetActive(false);
            level4.SetActive(false);
            level5.SetActive(true);
            level6.SetActive(false);
        }


        if (BossHp.WhatLevelNow == 6)
        {
            level1.SetActive(false);
            level2.SetActive(false);
            level3.SetActive(false);
            level4.SetActive(false);
            level5.SetActive(false);
            level6.SetActive(true);
        }
    }
}

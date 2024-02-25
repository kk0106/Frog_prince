using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxManger : MonoBehaviour
{
    public GameObject ax1;
    public GameObject ax2;
    public GameObject ax3;
    public GameObject ax4;
    public GameObject ax5;
    public GameObject ax6;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (BossHp.WhatLevelNow == 2)
        {
            ax1.SetActive(false);
        }

        if(BossHp.WhatLevelNow == 3)
        {
            ax1.SetActive(false);
            ax2.SetActive(false);
        }

        if (BossHp.WhatLevelNow == 4)
        {
            ax1.SetActive(false);
            ax2.SetActive(false);
            ax3.SetActive(false);
        }

        if (BossHp.WhatLevelNow == 5)
        {
            ax1.SetActive(false);
            ax2.SetActive(false);
            ax3.SetActive(false);
            ax4.SetActive(false);
        }

        if (BossHp.WhatLevelNow == 6)
        {
            ax1.SetActive(false);
            ax2.SetActive(false);
            ax3.SetActive(false);
            ax4.SetActive(false);
            ax5.SetActive(false);
        }
    }
}

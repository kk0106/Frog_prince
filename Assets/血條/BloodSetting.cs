using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodSetting : MonoBehaviour
{
    public GameObject playerblood;
    public GameObject bossblood;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        playerblood.SetActive(false);
        bossblood.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (time ==5)
        {
            Attack.anifloat = -1;
        }
        time-=Time.deltaTime;
        if(time < 3)
        {
            playerblood.SetActive(true);
        }
        if(time < 1)
        {
            bossblood.SetActive(true) ;
        }
        if(time < 0)
        {
            Attack.anifloat = 0;
            Attack.a = 1;
            Attack.b = 0;
            time = 0.5f;
        }
    }
}

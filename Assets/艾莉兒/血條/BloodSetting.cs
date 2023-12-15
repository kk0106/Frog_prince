using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodSetting : MonoBehaviour
{
    public GameObject bloom;
    public GameObject boss;
    public GameObject playerblood;
    public GameObject bossblood;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        bloom.SetActive(false);
        boss.SetActive(false);
        playerblood.SetActive(false);
        bossblood.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;

        if (time ==5)
        {
            attack1.SetAni = -1;
        }

        if (time < 3)
        {
           bloom.SetActive(true);
        }

        if (time < 1.6)
        {
            boss.SetActive(true);
            bloom.SetActive(false);
        }

        if (time < 1)
        {
            playerblood.SetActive(true);
            
        }


        if(time < 0.5)
        {
            bossblood.SetActive(true) ;
        }
        if(time < 0)
        {
            attack1.SetAni = 0;
            time = 0.5f;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public static bool PlayerCanAttack;
    public GameObject fort;
    private Vector3 FortPos;
    private float x;
    private float z;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        fort.SetActive(false);
        PlayerCanAttack = false;
    }

    // Update is called once per frame
    void Update()
    {
        FortPos=fort.transform.position;
       


        if (Attack.anifloat == 2)
        {
            PlayerCanAttack = true;
            x = Random.Range(-6, 27);
            z = Random.Range(-47, -68.5f);
        }
        if(PlayerCanAttack==true)
        {
            fort.SetActive(true);
            FortPos=new Vector3(x, 0.8843641f, z);
            time-=Time.deltaTime;
        }
        if (time < 0)
        {
            fort.SetActive (false);
           PlayerCanAttack=false;
            time = 5;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Attack : MonoBehaviour
{

    public float time;

    [Header("FindPlayerPos")]
    public GameObject player;
 // public GameObject hand;
    public Vector3 player_pos;

    [Header("HandAttackArea")]
    public int a;
    private int b;
    

    [Header("hand")]
    public GameObject ahand1;
    public GameObject ahand2;
    public GameObject ahand3;
    public GameObject ahand4;
    public GameObject ahand5;
    public GameObject ahand6;
    public GameObject handd;
    public GameObject bhand1;
    public GameObject bhand2;
    public GameObject bhand3;
    public GameObject bhand4;
    public GameObject bhand5;
    public GameObject handL1;
    public GameObject bhandL2;


    public static int anifloat;
    // Start is called before the first frame update
    void Start()
    {
        ahand1.SetActive(false);
        ahand2.SetActive(false);
        ahand3.SetActive(false);
        ahand4.SetActive(false);
        ahand5.SetActive(false);
        ahand6.SetActive(false);

        handd.SetActive(false);
            
        bhand1.SetActive(false);
        bhand2.SetActive(false);
        bhand3.SetActive(false);
        bhand4.SetActive(false);
        bhand5.SetActive(false);
       
        handL1.SetActive(false);
        bhandL2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (time == 5)
        {
            anifloat = 0;
        }

        if (anifloat==0)
        {
            time -= Time.deltaTime;
        }
        if (anifloat == 2)
        {
            ahand1.SetActive(false);
            ahand2.SetActive(false);
            ahand3.SetActive(false);
            ahand4.SetActive(false);
            ahand5.SetActive(false);
            ahand6.SetActive(false);

            handd.SetActive(false);

            bhand1.SetActive(false);
            bhand2.SetActive(false);
            bhand3.SetActive(false);
            bhand4.SetActive(false);
            bhand5.SetActive(false);

            handL1.SetActive(false);
            bhandL2.SetActive(false);

            time = 5;
        }

        player_pos =player.transform.position;

        if (a == 1)
        {
           ahand1.SetActive(true);
           ahand2.SetActive(true);
            
            anifloat = 1;

        }
        if (a == 2)
        {

            ahand3.SetActive(true);
            ahand4.SetActive(true);

            anifloat = 1;
        }
        if (a == 3)
        {

            ahand5.SetActive(true);
            ahand2.SetActive(true);

            anifloat = 1;
        }
        if (a == 4)
        {

            ahand1.SetActive(true);
            ahand6.SetActive(true);

            anifloat = 1;
        }
        if (a == 5)
        {
            handd.SetActive(true);
            ahand2.SetActive(true);

            anifloat = 1;

        }
        if (a == 6)
        {
            handL1.SetActive(true);
            ahand2.SetActive(true);

            anifloat = 1;

        }


        if (b == 1)
        {
            

        }
        if (b == 2)
        {
            

        }
        if (b == 3)
        {
            

        }
        if (b == 4)
        {
          

        }
        if (b == 5)
        {
           

        }
        if (b == 6)
        {
            

        }


        if (player_pos.x >10)
        {
            if (time < 0)
            {
                a = 2;
                        
            }
            
        }
        else
        {
            if(time < 0)
              {
                b= Random.Range(1, 6);  
               
              }
        }
        
    }
   
}

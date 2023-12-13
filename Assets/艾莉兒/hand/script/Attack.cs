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
    public static int a;
    public static int b;
    public static int Mark;

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


            Mark = 0;
            time = 5;
        }

        player_pos =player.transform.position;

        if (a == 1)
        {
         
           ahand2.SetActive(true);
            
            anifloat = 1;
          //  Mark = 1;

        }
        if (a == 2)
        {

            ahand3.SetActive(true);
            ahand4.SetActive(true);

            Mark = 2;
            anifloat = 1;
        }
        if (a == 3)
        {

            ahand5.SetActive(true);
            ahand6.SetActive(true);

            Mark=3;
            anifloat = 1;
        }
        if (a == 4)
        {

            
           
            ahand5.SetActive(true) ;

            Mark = 4;
            anifloat = 1;
        }
        if (a == 5)
        {
            handd.SetActive(true);
            ahand2.SetActive(true);
            ahand3.SetActive(true);

            Mark = 5;
            anifloat = 1;

        }
        if (a == 6)
        {
           
          
            handd.SetActive(true);
            ahand1.SetActive(true);

            Mark = 6;
            anifloat = 1;

        }


        if (b == 1)
        {

        
            bhand4.SetActive(true);

            Mark = 7;
            anifloat = 1;
        }
        if (b == 2)
        {
          
            bhand4.SetActive(true);

            Mark = 8;
            anifloat = 1;

        }
        if (b == 3)
        {
          
            bhand2.SetActive(true);

            Mark = 9;
            anifloat = 1;

        }
        if (b == 4)
        {
            handd.SetActive(true);
            bhand2.SetActive(true);
            bhand5.SetActive(true);

            anifloat = 1;
            Mark = 10;
        }
        if (b == 5)
        {
            handd.SetActive(true);
          
            bhand2.SetActive(true);

            anifloat = 1;
            Mark= 11;
        }
        if (b == 6)
        {

            
            handd.SetActive(true);
            bhand2.SetActive(true);
            
            Mark= 12;
            anifloat = 1;
        }


        if (player_pos.x >10&&time==5)
        {
           
                a = UnityEngine.Random.Range(1, 7);

            
            
        }
       if(player_pos.x <10&&time==5)
        {
           
              
                b= UnityEngine.Random.Range(1, 7);

            
        }
        
    }
   
}

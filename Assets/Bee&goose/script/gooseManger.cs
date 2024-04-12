using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class gooseManger : MonoBehaviour
{
    public GameObject bee;

    public float time;
    public float timeA;

    public float time1;
    public float timeB;

    public float time2;
    public float timeC;

    public float time3;
    public float timeD;

    public float time4;
    public float timeE;

    public float time5;
    public float timeF;

    public float time6;
    public float timeG;

  

    private Animator ani;
    private Animator ani2;
    private Animator ani3;
    private Animator ani4;
    private Animator ani5;
    private Animator ani6;
    private Animator ani7;
    
   


    public GameObject gos;
    public GameObject gos2;
    public GameObject gos3;
    public GameObject gos4;
    public GameObject gos5; 
    public GameObject gos6;
    public GameObject gos7;
  

    // Start is called before the first frame update
    void Start()
    {
        ani = gos.GetComponent<Animator>();
        ani2 = gos2.GetComponent<Animator>();
        ani3 = gos3.GetComponent<Animator>();
        ani4 = gos4.GetComponent<Animator>();
        ani5 = gos5.GetComponent<Animator>();
        ani6 = gos6.GetComponent<Animator>();
        ani7 = gos7.GetComponent<Animator>();
       

        //bee.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

        time -= Time.deltaTime;
        time1 -= Time.deltaTime;
        time2 -= Time.deltaTime;
        time3 -= Time.deltaTime;
        time4 -= Time.deltaTime;
        time5 -= Time.deltaTime;
        time6 -= Time.deltaTime;
      
     

        //1
        if (time < 0)
        {
            ani.SetBool("attack", true);
           
            bee.SetActive(false);
        }
        if(time < -1)
        {
            time = timeA;
        }

        if (time == timeA&&TriggerBall.isIN==1)
        {
            ani.SetBool("attack", false);
           
            bee.SetActive(true);

        }

        //2
        if (time1 < 0)
        {
          
            ani2.SetBool("attack", true);
         
            bee.SetActive(false);
        }
        if (time1 < -1)
        {
            time1 = timeB;
        }

        if (time1 == timeB && TriggerBall.isIN == 1)
        {
           
            ani2.SetBool("attack", false);
 
            bee.SetActive(true);

        }


        //3
        if (time2 < 0)
        {
           
            ani3.SetBool("attack", true);
           
            bee.SetActive(false);
        }
        if (time2 < -1)
        {
            time2 = timeC;
        }

        if (time2 == timeC && TriggerBall.isIN == 1)
        {
           
            ani3.SetBool("attack", false);
           
            bee.SetActive(true);

        }

        //4

        if (time3 < 0)
        {
            
            ani4.SetBool("attack", true);       

            bee.SetActive(false);
        }
        if (time3 < -1)
        {
            time3 = timeD;
        }

        if (time3 == timeD && TriggerBall.isIN == 1)
        {
           
            ani4.SetBool("attack", false);

            bee.SetActive(true);

        }

        //5
        if (time4 < 0)
        {
            ani5.SetBool("attack", true);

            bee.SetActive(false);
        }
        if (time4 < -1)
        {
            time4 = timeE;
        }

        if (time4 == timeE && TriggerBall.isIN == 1)
        {
          
            ani5.SetBool("attack", false);

            bee.SetActive(true);

        }

        //6
        if (time5< 0)
        {
            ani6.SetBool("attack", true);

            bee.SetActive(false);
        }
        if (time5 < -1)
        {
            time5 = timeF;
        }

        if (time5 == timeF && TriggerBall.isIN == 1)
        {
            ani6.SetBool("attack", false);

            bee.SetActive(true);

        }

        //7
        if (time6 < 0)
        {

            ani7.SetBool("attack", true);

            bee.SetActive(false);
        }
        if (time6 < -1)
        {
            time6 = timeG;
        }

        if (time6 == timeG && TriggerBall.isIN == 1)
        {

            ani7.SetBool("attack", false);

            bee.SetActive(true);

        }


        //8
      
    }
}

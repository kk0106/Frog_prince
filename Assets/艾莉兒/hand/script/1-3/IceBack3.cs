using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceBack3 : MonoBehaviour
{
    [Header("ChangeMaterial")]
    public Material[] material;
    public int x;



    public float time;
    public static int IceGoBack;
    public GameObject ice;
    public GameObject ice1;
    public GameObject ice2;
    public GameObject ice3;
    public GameObject ice4;
    public GameObject ice5;
    public GameObject ice6;
    public GameObject ice7;
    public GameObject ice8;
    public GameObject ice9;
    public GameObject ice10;
    public GameObject ice11;
    public GameObject ice12;
    public GameObject ice13;
    public GameObject ice14;
    public GameObject ice15;
    public GameObject ice16;
    public GameObject ice17;
    public GameObject ice18;

    public GameObject ice19;
    public GameObject ice20;
    public GameObject ice21;
  

    
    public GameObject fort;



    // Start is called before the first frame update
    void Start()
    {
        IceGoBack = 0;
        fort.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {

        ice19.GetComponent<Renderer>().sharedMaterial = material[0];
        ice20.GetComponent<Renderer>().sharedMaterial = material[0];
        ice21.GetComponent<Renderer>().sharedMaterial = material[0];
        // if (Attack.anifloat == 2)
        //  {
        //      time -= Time.deltaTime;
        // }
        if (findHand3.EndInt == 4)
        {
            fort.SetActive(false);
        }


        if (setAni3.Attacked == 1 && attack3.AttackValue == 9|| setAni3.Attacked == 1 && attack3.AttackValue == 10|| setAni3.Attacked == 1 && attack3.AttackValue == 11)
        {

            if(setAni3.Attacked == 1 && attack3.AttackValue == 9)
            {
                ice.SetActive(false);
                ice1.SetActive(false);
                ice2.SetActive(false);
                ice17.SetActive(false);
            }
           
            if(setAni3.Attacked == 1 && attack3.AttackValue == 10)
            {
                ice15.SetActive(false);
                ice9.SetActive(false);
                ice1.SetActive(false);
                ice3.SetActive(false);
                ice4.SetActive(false);
            }
           

            if(setAni3.Attacked == 1 && attack3.AttackValue == 11)
            {
               
                ice15.SetActive(false);
                ice17.SetActive(false);
                ice.SetActive(false);
                ice3.SetActive(false);
                ice4.SetActive(false);
                ice1.SetActive(false);
                ice2.SetActive(false);
                ice9.SetActive(false);
            }
            
        }
        else
        {
            ice1.SetActive(true);
            ice2.SetActive(true);
            ice17.SetActive(true);
            ice3.SetActive(true);
            ice4.SetActive(true);
            ice15.SetActive(true);
            ice9.SetActive(true);
            ice.SetActive(true);
           

            ice1.GetComponent<Renderer>().sharedMaterial = material[0];
            ice2.GetComponent<Renderer>().sharedMaterial = material[0];
            ice17.GetComponent<Renderer>().sharedMaterial = material[0];
            ice3.GetComponent<Renderer>().sharedMaterial = material[0];
            ice4.GetComponent<Renderer>().sharedMaterial = material[0];
            ice15.GetComponent<Renderer>().sharedMaterial = material[0];
            ice9.GetComponent<Renderer>().sharedMaterial = material[0];
            ice.GetComponent<Renderer>().sharedMaterial = material[0];
          
        }



        if (setAni3.Attacked == 1 && attack3.AttackValue == 10)
        {
            ice5.SetActive(false);
            ice6.SetActive(false);
            ice7.SetActive(false);
            ice8.SetActive(false);
            ice10.SetActive(false);

        }
        else
        {
            ice5.GetComponent<Renderer>().sharedMaterial = material[0];
            ice6.GetComponent<Renderer>().sharedMaterial = material[0];
            ice7.GetComponent<Renderer>().sharedMaterial = material[0];
            ice8.GetComponent<Renderer>().sharedMaterial = material[0];
            ice10.GetComponent<Renderer>().sharedMaterial = material[0];
            //attack1.Mark = 0;
            ice5.SetActive(true);
            ice6.SetActive(true);
            ice7.SetActive(true);
            ice8.SetActive(true);
            ice10.SetActive(true);
        }

        if (setAni3.Attacked == 1 && attack3.AttackValue == 11)
        {
        
            ice14.SetActive(false);
            ice16.SetActive(false);
            ice18.SetActive(false);
            ice11.SetActive(false);
            ice12.SetActive(true);
            ice13.SetActive(false);

        }
        else
        {

            // attack1.Mark = 0;
            ice14.GetComponent<Renderer>().sharedMaterial = material[0];
            ice16.GetComponent<Renderer>().sharedMaterial = material[0];
            ice18.GetComponent<Renderer>().sharedMaterial = material[0];
            ice11.GetComponent<Renderer>().sharedMaterial = material[0];
            ice12.GetComponent<Renderer>().sharedMaterial = material[0];
            ice13.GetComponent<Renderer>().sharedMaterial = material[0];

            ice14.SetActive(true);
            ice16.SetActive(true);
            ice18.SetActive(true);
            ice11.SetActive(true);
            ice12.SetActive(true);
            ice13.SetActive(true);
        }
     



        Debug.Log(attack3.SetAni);

        if (attack3.SetAni == 3)
        {

            attack3.SetAni = 2;
            IceGoBack = 1;


        }
        if (attack3.AttackValue == -1)
        {
            fort.transform.position = new Vector3(ice15.transform.position.x, 1.86f, ice15.transform.position.z);
            fort.SetActive(true);
            time -= Time.deltaTime;
            IceGoBack = 1;
        }
        if (!fort.activeInHierarchy)
        {
            time = 10;
        }
        if (time < 3)
        {
            attack3.WhichAttack = 5;
        }
        if (time < 0)
        {
            fort.SetActive(false);

        }

        if (attack3.Mark == 0)
        {
            ice.GetComponent<Renderer>().sharedMaterial = material[0];
            ice1.GetComponent<Renderer>().sharedMaterial = material[0];
            ice2.GetComponent<Renderer>().sharedMaterial = material[0];
            ice3.GetComponent<Renderer>().sharedMaterial = material[0];
            ice4.GetComponent<Renderer>().sharedMaterial = material[0];
            ice5.GetComponent<Renderer>().sharedMaterial = material[0];
            ice6.GetComponent<Renderer>().sharedMaterial = material[0];
            ice7.GetComponent<Renderer>().sharedMaterial = material[0];
            ice8.GetComponent<Renderer>().sharedMaterial = material[0];
            ice9.GetComponent<Renderer>().sharedMaterial = material[0];
            ice10.GetComponent<Renderer>().sharedMaterial = material[0];
            ice11.GetComponent<Renderer>().sharedMaterial = material[0];
            ice12.GetComponent<Renderer>().sharedMaterial = material[0];
            ice13.GetComponent<Renderer>().sharedMaterial = material[0];
            ice14.GetComponent<Renderer>().sharedMaterial = material[0];
            ice15.GetComponent<Renderer>().sharedMaterial = material[0];
            ice16.GetComponent<Renderer>().sharedMaterial = material[0];
            ice17.GetComponent<Renderer>().sharedMaterial = material[0];
            ice18.GetComponent<Renderer>().sharedMaterial = material[0];
           
        }

        if (attack3.Mark == 9)
        {
            ice1.GetComponent<Renderer>().sharedMaterial = material[1];
            ice2.GetComponent<Renderer>().sharedMaterial = material[1];
            ice17.GetComponent<Renderer>().sharedMaterial = material[1];
        }
        if (attack3.Mark == 10)
        {
            ice3.GetComponent<Renderer>().sharedMaterial = material[1];
            ice4.GetComponent<Renderer>().sharedMaterial = material[1];
            ice5.GetComponent<Renderer>().sharedMaterial = material[1];
            ice6.GetComponent<Renderer>().sharedMaterial = material[1];
            ice7.GetComponent<Renderer>().sharedMaterial = material[1];
            ice8.GetComponent<Renderer>().sharedMaterial = material[1];
            ice15.GetComponent<Renderer>().sharedMaterial = material[1];
            ice9.GetComponent<Renderer>().sharedMaterial = material[1];
            ice1.GetComponent<Renderer>().sharedMaterial = material[1];
            ice10.GetComponent<Renderer>().sharedMaterial = material[1];

        }
        if (attack3.Mark == 11)
        {
            ice14.GetComponent<Renderer>().sharedMaterial = material[1];
            ice15.GetComponent<Renderer>().sharedMaterial = material[1];
            ice16.GetComponent<Renderer>().sharedMaterial = material[1];
            ice17.GetComponent<Renderer>().sharedMaterial = material[1];
            ice18.GetComponent<Renderer>().sharedMaterial = material[1];
            ice11.GetComponent<Renderer>().sharedMaterial = material[1];
            ice3.GetComponent<Renderer>().sharedMaterial = material[1];
            ice4.GetComponent<Renderer>().sharedMaterial = material[1];
            ice12.GetComponent<Renderer>().sharedMaterial = material[1];
            ice.GetComponent<Renderer>().sharedMaterial = material[1];
            ice13.GetComponent<Renderer>().sharedMaterial = material[1];
            ice1.GetComponent<Renderer>().sharedMaterial = material[1];
            ice9.GetComponent<Renderer>().sharedMaterial = material[1];
            ice2.GetComponent<Renderer>().sharedMaterial = material[1];
        }


    }
}

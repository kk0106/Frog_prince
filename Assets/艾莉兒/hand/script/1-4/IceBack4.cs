using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceBack4 : MonoBehaviour
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
    public GameObject ice22;

    public GameObject ice23;
    public GameObject ice24;

    public GameObject ice25;
    public GameObject ice26;

    public GameObject ice27;
    public GameObject ice28;
    public GameObject ice29;
    public GameObject ice30;
    public GameObject ice31;
    public GameObject ice32;
    public GameObject ice33;
    public GameObject ice34;

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
        // if (Attack.anifloat == 2)
        //  {
        //      time -= Time.deltaTime;
        // }
        if (findHand4.EndInt == 5)
        {
            fort.SetActive(false);
        }


        if (setAni4.Attacked == 1 && attack4.AttackValue == 12|| setAni4.Attacked == 1 && attack4.AttackValue == 13|| setAni4.Attacked == 1 && attack4.AttackValue == 14)
        {
            if (setAni4.Attacked == 1 && attack4.AttackValue == 12)
            {
                ice16.SetActive(false);
                ice12.SetActive(false);
                ice7.SetActive(false);
                ice3.SetActive(false);
                ice21.SetActive(false);

                ice23.SetActive(false);
                ice18.SetActive(false);
                ice9.SetActive(false);
                ice14.SetActive(false);

                ice8.SetActive(false);
                ice5.SetActive(false);
                ice6.SetActive(false);

            }

            if (setAni4.Attacked == 1 && attack4.AttackValue == 13)
            {
                ice23.SetActive(false);
                ice21.SetActive(false);
                ice3.SetActive(false);
                ice12.SetActive(false);
                ice14.SetActive(false);

            }

            if (setAni4.Attacked == 1 && attack4.AttackValue == 14)
            {
                ice7.SetActive(false);
                ice9.SetActive(false);
                ice16.SetActive(false);
                ice18.SetActive(false);
                ice8.SetActive(false);
                ice5.SetActive(false);
                ice6.SetActive(false);

            }
        }
        else
        {
            ice16.GetComponent<Renderer>().sharedMaterial = material[0];
            ice12.GetComponent<Renderer>().sharedMaterial = material[0];
            ice7.GetComponent<Renderer>().sharedMaterial = material[0];
            ice3.GetComponent<Renderer>().sharedMaterial = material[0];
            ice18.GetComponent<Renderer>().sharedMaterial = material[0];
            ice14.GetComponent<Renderer>().sharedMaterial = material[0];
            ice9.GetComponent<Renderer>().sharedMaterial = material[0];
            ice21.GetComponent<Renderer>().sharedMaterial = material[0];
            ice23.GetComponent<Renderer>().sharedMaterial = material[0];
            ice5.GetComponent<Renderer>().sharedMaterial = material[0];
            ice6.GetComponent<Renderer>().sharedMaterial = material[0];
            ice8.GetComponent<Renderer>().sharedMaterial = material[0];

            ice16.SetActive(true);
            ice12.SetActive(true);
            ice7.SetActive(true);
            ice3.SetActive(true);
            ice18.SetActive(true);
            ice14.SetActive(true);
            ice9.SetActive(true);
            ice21.SetActive(true);
            ice23.SetActive(true);
            ice5.SetActive(true);
            ice6.SetActive(true);
            ice8.SetActive(true);

        }


        

        if (setAni4.Attacked == 1 && attack4.AttackValue == 13)
        {
            ice.SetActive(false);
            ice1.SetActive(false);
            ice2.SetActive(false);
            ice4.SetActive(false);

            ice10.SetActive(false);
            ice11.SetActive(false);
            ice13.SetActive(false);

            ice20.SetActive(false);
           // ice21.SetActive(false);
            ice22.SetActive(false);
           // ice23.SetActive(false);
            ice24.SetActive(false);
          

        }
        else
        {
            ice.GetComponent<Renderer>().sharedMaterial = material[0];
            ice1.GetComponent<Renderer>().sharedMaterial = material[0];
            ice2.GetComponent<Renderer>().sharedMaterial = material[0];
            ice4.GetComponent<Renderer>().sharedMaterial = material[0];
            ice10.GetComponent<Renderer>().sharedMaterial = material[0];
            ice11.GetComponent<Renderer>().sharedMaterial = material[0];
            ice13.GetComponent<Renderer>().sharedMaterial = material[0];
            ice20.GetComponent<Renderer>().sharedMaterial = material[0];
          //  ice21.GetComponent<Renderer>().sharedMaterial = material[0];
            ice22.GetComponent<Renderer>().sharedMaterial = material[0];
           // ice23.GetComponent<Renderer>().sharedMaterial = material[0];
            ice24.GetComponent<Renderer>().sharedMaterial = material[0];
            
            ice.SetActive(true);
            ice1.SetActive(true);
            ice2.SetActive(true);
            ice4.SetActive(true);
            ice10.SetActive(true);
            ice11.SetActive(true);
            ice13.SetActive(true);
            ice20.SetActive(true);
          //  ice21.SetActive(true);
            ice22.SetActive(true);
           // ice23.SetActive(true);
            ice24.SetActive(true);
           
        }

        if (setAni4.Attacked == 1 && attack4.AttackValue == 14)
        {
           

            ice15.SetActive(false);
            ice17.SetActive(false);
            ice19.SetActive(false);

            ice25.SetActive(false);
            ice26.SetActive(false);
            ice27.SetActive(false);
            ice28.SetActive(false);
            ice29.SetActive(false);

            ice30.SetActive(false);
            ice31.SetActive(false);
            ice32.SetActive(false);
            ice33.SetActive(false);
            ice34.SetActive(false);
           


        }
        else
        {

            // attack1.Mark = 0;
          
            ice15.GetComponent<Renderer>().sharedMaterial = material[0];
            ice17.GetComponent<Renderer>().sharedMaterial = material[0];
            ice19.GetComponent<Renderer>().sharedMaterial = material[0];
            ice25.GetComponent<Renderer>().sharedMaterial = material[0];
            ice26.GetComponent<Renderer>().sharedMaterial = material[0];
            ice27.GetComponent<Renderer>().sharedMaterial = material[0];
            ice28.GetComponent<Renderer>().sharedMaterial = material[0];
            ice29.GetComponent<Renderer>().sharedMaterial = material[0];
            ice30.GetComponent<Renderer>().sharedMaterial = material[0];
            ice31.GetComponent<Renderer>().sharedMaterial = material[0];
            ice32.GetComponent<Renderer>().sharedMaterial = material[0];
            ice33.GetComponent<Renderer>().sharedMaterial = material[0];
            ice34.GetComponent<Renderer>().sharedMaterial = material[0];

            
            ice15.SetActive(true);
            ice17.SetActive(true);
            ice19.SetActive(true);
            ice25.SetActive(true);
            ice26.SetActive(true);
            ice27.SetActive(true);
            ice28.SetActive(true);
            ice29.SetActive(true);
            ice30.SetActive(true);
            ice31.SetActive(true);
            ice32.SetActive(true);
            ice33.SetActive(true);
            ice34.SetActive(true);
          
        }
      


        Debug.Log(attack4.SetAni);

        if (attack4.SetAni == 3)
        {

            attack4.SetAni = 2;
            IceGoBack = 1;


        }
        if (attack4.AttackValue == -1)
        {
            fort.transform.position = new Vector3(ice33.transform.position.x, 1.86f, ice33.transform.position.z);
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
            attack4.WhichAttack = 5;
        }
        if (time < 0)
        {
            fort.SetActive(false);

        }

        if (attack4.Mark == 0)
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
            ice19.GetComponent<Renderer>().sharedMaterial = material[0];
            ice20.GetComponent<Renderer>().sharedMaterial = material[0];
            ice21.GetComponent<Renderer>().sharedMaterial = material[0];
            ice22.GetComponent<Renderer>().sharedMaterial = material[0];
            ice23.GetComponent<Renderer>().sharedMaterial = material[0];
            ice24.GetComponent<Renderer>().sharedMaterial = material[0];
            ice25.GetComponent<Renderer>().sharedMaterial = material[0];
            ice26.GetComponent<Renderer>().sharedMaterial = material[0];
            ice27.GetComponent<Renderer>().sharedMaterial = material[0];
            ice28.GetComponent<Renderer>().sharedMaterial = material[0];
            ice29.GetComponent<Renderer>().sharedMaterial = material[0];
            ice30.GetComponent<Renderer>().sharedMaterial = material[0];
            ice31.GetComponent<Renderer>().sharedMaterial = material[0];
            ice32.GetComponent<Renderer>().sharedMaterial = material[0];
            ice33.GetComponent<Renderer>().sharedMaterial = material[0];
            ice34.GetComponent<Renderer>().sharedMaterial = material[0];
        }

        if (attack4.Mark == 12)
        {
            ice16.GetComponent<Renderer>().sharedMaterial = material[1];
            ice12.GetComponent<Renderer>().sharedMaterial = material[1];
            ice7.GetComponent<Renderer>().sharedMaterial = material[1];
            ice3.GetComponent<Renderer>().sharedMaterial = material[1];
            ice18.GetComponent<Renderer>().sharedMaterial = material[1];
            ice14.GetComponent<Renderer>().sharedMaterial = material[1];
            ice9.GetComponent<Renderer>().sharedMaterial = material[1];

            ice5.GetComponent<Renderer>().sharedMaterial = material[1];
            ice6.GetComponent<Renderer>().sharedMaterial = material[1];
            ice7.GetComponent<Renderer>().sharedMaterial = material[1];
            ice8.GetComponent<Renderer>().sharedMaterial = material[1];
            ice9.GetComponent<Renderer>().sharedMaterial = material[1];
        }
        if (attack4.Mark == 13)
        {
            ice.GetComponent<Renderer>().sharedMaterial = material[1];
            ice1.GetComponent<Renderer>().sharedMaterial = material[1];
            ice2.GetComponent<Renderer>().sharedMaterial = material[1];
            ice3.GetComponent<Renderer>().sharedMaterial = material[1];
            ice4.GetComponent<Renderer>().sharedMaterial = material[1];

            ice10.GetComponent<Renderer>().sharedMaterial = material[1];
            ice11.GetComponent<Renderer>().sharedMaterial = material[1];
            ice12.GetComponent<Renderer>().sharedMaterial = material[1];
            ice13.GetComponent<Renderer>().sharedMaterial = material[1];
            ice14.GetComponent<Renderer>().sharedMaterial = material[1];

            ice20.GetComponent<Renderer>().sharedMaterial = material[1];
            ice21.GetComponent<Renderer>().sharedMaterial = material[1];
            ice22.GetComponent<Renderer>().sharedMaterial = material[1];
            ice23.GetComponent<Renderer>().sharedMaterial = material[1];
            ice24.GetComponent<Renderer>().sharedMaterial = material[1];


        }
        if (attack4.Mark == 14)
        {
            ice5.GetComponent<Renderer>().sharedMaterial = material[1];
            ice6.GetComponent<Renderer>().sharedMaterial = material[1];
            ice7.GetComponent<Renderer>().sharedMaterial = material[1];
            ice8.GetComponent<Renderer>().sharedMaterial = material[1];
            ice9.GetComponent<Renderer>().sharedMaterial = material[1];

            ice15.GetComponent<Renderer>().sharedMaterial = material[1];
            ice16.GetComponent<Renderer>().sharedMaterial = material[1];
            ice17.GetComponent<Renderer>().sharedMaterial = material[1];
            ice18.GetComponent<Renderer>().sharedMaterial = material[1];
            ice19.GetComponent<Renderer>().sharedMaterial = material[1];

            ice25.GetComponent<Renderer>().sharedMaterial = material[1];
            ice26.GetComponent<Renderer>().sharedMaterial = material[1];
            ice27.GetComponent<Renderer>().sharedMaterial = material[1];
            ice28.GetComponent<Renderer>().sharedMaterial = material[1];
            ice29.GetComponent<Renderer>().sharedMaterial = material[1];

            ice30.GetComponent<Renderer>().sharedMaterial = material[1];
            ice31.GetComponent<Renderer>().sharedMaterial = material[1];
            ice32.GetComponent<Renderer>().sharedMaterial = material[1];
            ice33.GetComponent<Renderer>().sharedMaterial = material[1];
            ice34.GetComponent<Renderer>().sharedMaterial = material[1];


        }
        

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceBack2 : MonoBehaviour
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
        


        if ( setAni2.Attacked == 1 && attack2.AttackValue == 6)
        {
            ice.SetActive(false);
            ice1.SetActive(false);
            ice2.SetActive(false);
            ice3.SetActive(false);


        }
        else
        {
            ice.GetComponent<Renderer>().sharedMaterial = material[0];
            ice1.GetComponent<Renderer>().sharedMaterial = material[0];
            ice2.GetComponent<Renderer>().sharedMaterial = material[0];
            ice3.GetComponent<Renderer>().sharedMaterial = material[0];

            ice.SetActive(true);
            ice1.SetActive(true);
            ice2.SetActive(true);
            ice3.SetActive(true);

        }



        if (setAni2.Attacked == 1 && attack2.AttackValue == 7)
        {
            ice4.SetActive(false);
            ice5.SetActive(false);
            ice6.SetActive(false);
            ice7.SetActive(false);


        }
        else
        {


            ice4.GetComponent<Renderer>().sharedMaterial = material[0];
            ice5.GetComponent<Renderer>().sharedMaterial = material[0];
            ice6.GetComponent<Renderer>().sharedMaterial = material[0];
            ice7.GetComponent<Renderer>().sharedMaterial = material[0];

            ice4.SetActive(true);
            ice5.SetActive(true);
            ice6.SetActive(true);
            ice7.SetActive(true);

        }

        if (setAni2.Attacked == 1 && attack2.AttackValue == 8)
        {
            ice8.SetActive(false);
            ice9.SetActive(false);
            ice10.SetActive(false);
            ice3.SetActive(false);
            ice7.SetActive(false);

        }
        else
        {
            ice10.GetComponent<Renderer>().sharedMaterial = material[0];
            ice9.GetComponent<Renderer>().sharedMaterial = material[0];
            ice8.GetComponent<Renderer>().sharedMaterial = material[0];
            ice3.GetComponent<Renderer>().sharedMaterial = material[0];
            ice7.GetComponent<Renderer>().sharedMaterial = material[0];
            //attack1.Mark = 0;
            ice10.SetActive(true);
            ice9.SetActive(true);
            ice8.SetActive(true);
            ice3.SetActive(true);
            ice7.SetActive(true);
        }

        if (attack2.SetAni == 3)
        {

            attack2.SetAni = 2;
            IceGoBack = 1;


        }
        if (attack2.AttackValue == -1)
        {
            fort.transform.position = new Vector3(ice10.transform.position.x, 1.86f, ice10.transform.position.z);
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
            attack2.WhichAttack = 5;
        }

        if (time < 0)
        {
            fort.SetActive(false);

        }

        if (attack2.Mark == 0)
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
            
        }

       
        if (attack2.Mark == 6)
        {
            ice.GetComponent<Renderer>().sharedMaterial = material[1];
            ice1.GetComponent<Renderer>().sharedMaterial = material[1];
            ice2.GetComponent<Renderer>().sharedMaterial = material[1];
            ice3.GetComponent<Renderer>().sharedMaterial = material[1];

        }
        if (attack2.Mark == 7)
        {
            ice4.GetComponent<Renderer>().sharedMaterial = material[1];
            ice5.GetComponent<Renderer>().sharedMaterial = material[1];
            ice6.GetComponent<Renderer>().sharedMaterial = material[1];
            ice7.GetComponent<Renderer>().sharedMaterial = material[1];


        }
        if (attack2 .Mark == 8)
        {
            ice8.GetComponent<Renderer>().sharedMaterial = material[1];
            ice9.GetComponent<Renderer>().sharedMaterial = material[1];
            ice3.GetComponent<Renderer>().sharedMaterial = material[1];
            ice7.GetComponent<Renderer>().sharedMaterial = material[1];
            ice10.GetComponent<Renderer>().sharedMaterial = material[1];
        }


    }
}

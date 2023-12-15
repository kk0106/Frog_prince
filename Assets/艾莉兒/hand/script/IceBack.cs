using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IceBack : MonoBehaviour
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
  
   
        

    // Start is called before the first frame update
    void Start()
    {
        IceGoBack= 0;
    }

    // Update is called once per frame
    void Update()
    {
        // if (Attack.anifloat == 2)
        //  {
        //      time -= Time.deltaTime;
        // }

        if (setAni.Attacked == 1 && attack1.WhichAttack == 1)
        {
            ice.SetActive(false);
            ice1.SetActive(false);
            ice2.SetActive(false);
            ice3.SetActive(false);
            ice4.SetActive(false);
          
        }

        if (attack1.SetAni == 2)
        {
            ice.SetActive(true);
            ice1.SetActive(true);
            ice2.SetActive(true);                
            ice3.SetActive(true);
            ice4.SetActive(true);             
            ice5.SetActive(true);
            ice6.SetActive(true);
            ice7.SetActive(true);
            ice8.SetActive(true);
            ice9.SetActive(true);
            ice10.SetActive(true);
            ice11.SetActive(true);
            ice12.SetActive(true);     
            ice13.SetActive(true);
            ice14.SetActive(true);               
            ice15.SetActive(true);
            ice16.SetActive(true);
            ice17.SetActive(true);
            ice18.SetActive(true);              
            ice19.SetActive(true);
            ice20.SetActive(true);               
            ice21.SetActive(true);
            ice22.SetActive(true);
            ice23.SetActive(true);
            ice24.SetActive(true);
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

            IceGoBack = 1;
        }
        //  if (time < 0)
        //   {
        //     time = 3;

        //  }

        if (attack1.Mark == 0)
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

        if (attack1.Mark == 1)
        {
            ice1.GetComponent<Renderer>().sharedMaterial = material[1];
            ice2.GetComponent<Renderer>().sharedMaterial = material[1];
            ice3.GetComponent<Renderer>().sharedMaterial = material[1];
            ice4.GetComponent<Renderer>().sharedMaterial = material[1];
            ice.GetComponent<Renderer>().sharedMaterial = material[1];
        }
        if (attack1.Mark == 2)
        {
            ice11.GetComponent<Renderer>().sharedMaterial = material[1];
            ice12.GetComponent<Renderer>().sharedMaterial = material[1];
            ice13.GetComponent<Renderer>().sharedMaterial = material[1];
            ice14.GetComponent<Renderer>().sharedMaterial = material[1];
            ice10.GetComponent<Renderer>().sharedMaterial = material[1];

        }
        if (attack1.Mark == 3)
        {
            ice21.GetComponent<Renderer>().sharedMaterial = material[1];
            ice22.GetComponent<Renderer>().sharedMaterial = material[1];
            ice23.GetComponent<Renderer>().sharedMaterial = material[1];
            ice24.GetComponent<Renderer>().sharedMaterial = material[1];
            ice20.GetComponent<Renderer>().sharedMaterial = material[1];
        }
        if (attack1.Mark == 4)
        {
            ice6.GetComponent<Renderer>().sharedMaterial = material[1];
            ice7.GetComponent<Renderer>().sharedMaterial = material[1];
            ice8.GetComponent<Renderer>().sharedMaterial = material[1];
            ice9.GetComponent<Renderer>().sharedMaterial = material[1];
            ice5.GetComponent<Renderer>().sharedMaterial = material[1];
            ice16.GetComponent<Renderer>().sharedMaterial = material[1];
            ice17.GetComponent<Renderer>().sharedMaterial = material[1];
            ice18.GetComponent<Renderer>().sharedMaterial = material[1];
            ice19.GetComponent<Renderer>().sharedMaterial = material[1];
            ice15.GetComponent<Renderer>().sharedMaterial = material[1];
        }
    }
}

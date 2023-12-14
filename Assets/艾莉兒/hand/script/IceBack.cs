using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceBack : MonoBehaviour
{
    public float time;
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
    public GameObject ice35;
    public GameObject ice36;
    public GameObject ice37;
   
        

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // if (Attack.anifloat == 2)
      //  {
      //      time -= Time.deltaTime;
       // }
        if (Attack.anifloat == 2)
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
            ice35.SetActive(true);
            ice36.SetActive(true);
            ice37.SetActive(true);
           
        }
        //  if (time < 0)
        //   {
        //     time = 3;

        //  }

        if (Attack.Mark == 0)
        {
            ice1.GetComponent<MeshRenderer>().material.color = Color.white;
            ice2.GetComponent<MeshRenderer>().material.color = Color.white;
            ice3.GetComponent<MeshRenderer>().material.color = Color.white;
            ice5.GetComponent<MeshRenderer>().material.color = Color.white;
            ice6.GetComponent<MeshRenderer>().material.color = Color.white;
            ice7.GetComponent<MeshRenderer>().material.color = Color.white;
            ice8.GetComponent<MeshRenderer>().material.color = Color.white;
            ice9.GetComponent<MeshRenderer>().material.color = Color.white;
            ice11.GetComponent<MeshRenderer>().material.color = Color.white;
            ice12.GetComponent<MeshRenderer>().material.color = Color.white;
            ice13.GetComponent<MeshRenderer>().material.color = Color.white;
            ice15.GetComponent<MeshRenderer>().material.color = Color.white;
            ice16.GetComponent<MeshRenderer>().material.color = Color.white;
            ice17.GetComponent<MeshRenderer>().material.color = Color.white;
            ice18.GetComponent<MeshRenderer>().material.color = Color.white;
            ice19.GetComponent<MeshRenderer>().material.color = Color.white;
            ice22.GetComponent<MeshRenderer>().material.color = Color.white;
            ice23.GetComponent<MeshRenderer>().material.color = Color.white;
            ice24.GetComponent<MeshRenderer>().material.color = Color.white;
            ice25.GetComponent<MeshRenderer>().material.color = Color.white;
            ice27.GetComponent<MeshRenderer>().material.color = Color.white;
            ice28.GetComponent<MeshRenderer>().material.color = Color.white;
            ice29.GetComponent<MeshRenderer>().material.color = Color.white;
            ice30.GetComponent<MeshRenderer>().material.color = Color.white;
            ice31.GetComponent<MeshRenderer>().material.color = Color.white;
            ice33.GetComponent<MeshRenderer>().material.color = Color.white;
            ice34.GetComponent<MeshRenderer>().material.color = Color.white;
            ice35.GetComponent<MeshRenderer>().material.color = Color.white;
          
        }

        if (Attack.Mark == 1)
        {
           ice16.GetComponent<MeshRenderer>().material.color = Color.red;
           ice17.GetComponent<MeshRenderer>().material.color = Color.red;
           ice18.GetComponent<MeshRenderer>().material.color = Color.red;         
        }
        if (Attack.Mark == 2)
        {
            ice22.GetComponent<MeshRenderer>().material.color = Color.red;
            ice23.GetComponent<MeshRenderer>().material.color = Color.red;
            ice24.GetComponent<MeshRenderer>().material.color = Color.red;
            ice25.GetComponent<MeshRenderer>().material.color = Color.red;
            ice17.GetComponent<MeshRenderer>().material.color = Color.red;
            ice18.GetComponent<MeshRenderer>().material.color = Color.red;
            ice12.GetComponent<MeshRenderer>().material.color = Color.red;
            ice13.GetComponent<MeshRenderer>().material.color = Color.red;
            ice7.GetComponent<MeshRenderer>().material.color = Color.red;
            ice8.GetComponent<MeshRenderer>().material.color = Color.red;
            ice2.GetComponent<MeshRenderer>().material.color = Color.red;
            ice3.GetComponent<MeshRenderer>().material.color = Color.red;
            ice30.GetComponent<MeshRenderer>().material.color = Color.red;
            ice31.GetComponent<MeshRenderer>().material.color = Color.red;
  
        }

        if (Attack.Mark == 3)
        {
            ice22.GetComponent<MeshRenderer>().material.color = Color.red;
            ice23.GetComponent<MeshRenderer>().material.color = Color.red;
            
            ice17.GetComponent<MeshRenderer>().material.color = Color.red;
            ice18.GetComponent<MeshRenderer>().material.color = Color.red;
            ice12.GetComponent<MeshRenderer>().material.color = Color.red;
            ice13.GetComponent<MeshRenderer>().material.color = Color.red;
            ice7.GetComponent<MeshRenderer>().material.color = Color.red;
            ice8.GetComponent<MeshRenderer>().material.color = Color.red;
            ice2.GetComponent<MeshRenderer>().material.color = Color.red;
            ice3.GetComponent<MeshRenderer>().material.color = Color.red;
            ice30.GetComponent<MeshRenderer>().material.color = Color.red;
            ice31.GetComponent<MeshRenderer>().material.color = Color.red;
            ice24.GetComponent<MeshRenderer>().material.color = Color.red;
            ice19.GetComponent<MeshRenderer>().material.color = Color.red;
            ice15.GetComponent<MeshRenderer>().material.color = Color.red;
            ice9.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        if (Attack.Mark == 4)
        {
            ice22.GetComponent<MeshRenderer>().material.color = Color.red;
            ice23.GetComponent<MeshRenderer>().material.color = Color.red;
            ice17.GetComponent<MeshRenderer>().material.color = Color.red;
            ice18.GetComponent<MeshRenderer>().material.color = Color.red;
            ice12.GetComponent<MeshRenderer>().material.color = Color.red;
            ice13.GetComponent<MeshRenderer>().material.color = Color.red;
            ice7.GetComponent<MeshRenderer>().material.color = Color.red;
            ice8.GetComponent<MeshRenderer>().material.color = Color.red;
            ice2.GetComponent<MeshRenderer>().material.color = Color.red;
            ice3.GetComponent<MeshRenderer>().material.color = Color.red;
            ice30.GetComponent<MeshRenderer>().material.color = Color.red;
            ice31.GetComponent<MeshRenderer>().material.color = Color.red;
        }

        if (Attack.Mark == 5)
        {
            ice5.GetComponent<MeshRenderer>().material.color = Color.red;
            ice6.GetComponent<MeshRenderer>().material.color = Color.red;
            ice7.GetComponent<MeshRenderer>().material.color = Color.red;

            ice16.GetComponent<MeshRenderer>().material.color = Color.red;           
            ice17.GetComponent<MeshRenderer>().material.color = Color.red;
            ice18.GetComponent<MeshRenderer>().material.color = Color.red;

            ice22.GetComponent<MeshRenderer>().material.color = Color.red;
            ice23.GetComponent<MeshRenderer>().material.color = Color.red;
            ice24.GetComponent<MeshRenderer>().material.color = Color.red;
            ice25.GetComponent<MeshRenderer>().material.color = Color.red;
           
        }
        if (Attack.Mark == 6)
        {
            ice5.GetComponent<MeshRenderer>().material.color = Color.red;
            ice6.GetComponent<MeshRenderer>().material.color = Color.red;
            ice7.GetComponent<MeshRenderer>().material.color = Color.red;

            ice11.GetComponent<MeshRenderer>().material.color = Color.red;
            ice12.GetComponent<MeshRenderer>().material.color = Color.red;
            ice13.GetComponent<MeshRenderer>().material.color = Color.red;
            ice15.GetComponent<MeshRenderer>().material.color = Color.red;
        }

        if (Attack.Mark == 7)
        {
            ice33.GetComponent<MeshRenderer>().material.color = Color.red;
            ice34.GetComponent<MeshRenderer>().material.color = Color.red;
            ice28.GetComponent<MeshRenderer>().material.color = Color.red;
            ice29.GetComponent<MeshRenderer>().material.color = Color.red;
            ice1.GetComponent<MeshRenderer>().material.color = Color.red;
            ice2.GetComponent<MeshRenderer>().material.color = Color.red;
            ice7.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        if (Attack.Mark == 8)
        {
            ice33.GetComponent<MeshRenderer>().material.color = Color.red;
            ice34.GetComponent<MeshRenderer>().material.color = Color.red;
            ice28.GetComponent<MeshRenderer>().material.color = Color.red;
            ice29.GetComponent<MeshRenderer>().material.color = Color.red;
            ice1.GetComponent<MeshRenderer>().material.color = Color.red;
            ice2.GetComponent<MeshRenderer>().material.color = Color.red;
            ice7.GetComponent<MeshRenderer>().material.color = Color.red;
        }

        if (Attack.Mark == 9)
        {
            ice27.GetComponent<MeshRenderer>().material.color = Color.red;
            ice28.GetComponent<MeshRenderer>().material.color = Color.red;
            ice29.GetComponent<MeshRenderer>().material.color = Color.red;
            ice30.GetComponent<MeshRenderer>().material.color = Color.red;
            ice31.GetComponent<MeshRenderer>().material.color = Color.red;
          
        }
        if (Attack.Mark == 10)
        {
            ice5.GetComponent<MeshRenderer>().material.color = Color.red;
            ice6.GetComponent<MeshRenderer>().material.color = Color.red;
            ice7.GetComponent<MeshRenderer>().material.color = Color.red;

            ice27.GetComponent<MeshRenderer>().material.color = Color.red;
            ice28.GetComponent<MeshRenderer>().material.color = Color.red;
            ice29.GetComponent<MeshRenderer>().material.color = Color.red;
            ice30.GetComponent<MeshRenderer>().material.color = Color.red;
            ice31.GetComponent<MeshRenderer>().material.color = Color.red;

            ice34.GetComponent<MeshRenderer>().material.color = Color.red;
            ice35.GetComponent<MeshRenderer>().material.color = Color.red;
            ice29.GetComponent<MeshRenderer>().material.color = Color.red;
            ice30.GetComponent<MeshRenderer>().material.color = Color.red;
            ice2.GetComponent<MeshRenderer>().material.color = Color.red;
            ice3.GetComponent<MeshRenderer>().material.color = Color.red;
            ice8.GetComponent<MeshRenderer>().material.color = Color.red;
            ice9.GetComponent<MeshRenderer>().material.color = Color.red;
            ice15.GetComponent<MeshRenderer>().material.color = Color.red;
        }

        if (Attack.Mark == 11)
        {
            ice5.GetComponent<MeshRenderer>().material.color = Color.red;
            ice6.GetComponent<MeshRenderer>().material.color = Color.red;
            ice7.GetComponent<MeshRenderer>().material.color = Color.red;

            ice27.GetComponent<MeshRenderer>().material.color = Color.red;
            ice28.GetComponent<MeshRenderer>().material.color = Color.red;
            ice29.GetComponent<MeshRenderer>().material.color = Color.red;
            ice30.GetComponent<MeshRenderer>().material.color = Color.red;
            ice31.GetComponent<MeshRenderer>().material.color = Color.red;

        }
        if (Attack.Mark == 12)
        {
            ice5.GetComponent<MeshRenderer>().material.color = Color.red;
            ice6.GetComponent<MeshRenderer>().material.color = Color.red;
            ice7.GetComponent<MeshRenderer>().material.color = Color.red;

            ice27.GetComponent<MeshRenderer>().material.color = Color.red;
            ice28.GetComponent<MeshRenderer>().material.color = Color.red;
            ice29.GetComponent<MeshRenderer>().material.color = Color.red;
            ice30.GetComponent<MeshRenderer>().material.color = Color.red;
            ice31.GetComponent<MeshRenderer>().material.color = Color.red;
        }

    }
}

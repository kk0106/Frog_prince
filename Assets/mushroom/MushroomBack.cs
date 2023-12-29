using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomBack : MonoBehaviour
{
    public GameObject a1;
    public GameObject a2;
    public GameObject a3;
    public GameObject a4;
    public GameObject a5;
    public GameObject a6;
    public GameObject a7;
    public GameObject a8;
    public GameObject a9;
    public GameObject a10;
    public GameObject a11;
    public GameObject a12;
    public GameObject a13;
    public GameObject a14;
    public GameObject a15;
    public GameObject a16;
    public GameObject a17;
    public GameObject a18;

    public float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (time < 0)
        {
            a1.SetActive(true);
            a2.SetActive(true);
            a3.SetActive(true);
            a4.SetActive(true);
            a5.SetActive(true);
            a6.SetActive(true);            
            a7.SetActive(true);
            a8.SetActive(true);
            a9.SetActive(true);
            a10.SetActive(true);
            a11.SetActive(true);
            a12.SetActive(true);           
            a13.SetActive(true);
            a14.SetActive(true);
            a15.SetActive(true);
            a16.SetActive(true);
            a17.SetActive(true);
            a18.SetActive(true);
            time = 5;


        }

        if (!a1.activeInHierarchy || !a2.activeInHierarchy|| !a3.activeInHierarchy || !a4.activeInHierarchy|| !a5.activeInHierarchy || !a6.activeInHierarchy|| !a7.activeInHierarchy || !a8.activeInHierarchy||
            !a9.activeInHierarchy || !a10.activeInHierarchy|| !a11.activeInHierarchy || !a12.activeInHierarchy|| !a13.activeInHierarchy || !a14.activeInHierarchy || !a15.activeInHierarchy || !a16.activeInHierarchy || 
            !a17.activeInHierarchy || !a18.activeInHierarchy )
        {
            time-=Time.deltaTime;
        }
    }
}

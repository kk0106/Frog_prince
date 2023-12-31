using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poision : MonoBehaviour
{
    public GameObject bubble;
  
    public float a;

    public float Ins_Time = 1;
    public Transform[] points;

   
    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("ins", Ins_Time, Ins_Time);
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ins()
    {
        int Random_points = Random.Range(0, points.Length);

        Instantiate(bubble, points[Random_points].transform.position, points[Random_points].transform.rotation)         ;
    }
  
       
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldApple : MonoBehaviour
{
    public GameObject Goldapple;
    public Transform[] points;

    public float Ins_time=2;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ApppleDown", Ins_time, Ins_time);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void ApppleDown()
    {
        int Random_points=Random.Range(0, points.Length);

        Instantiate(Goldapple, points[Random_points].transform.position, points[Random_points].transform.rotation);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startBall : MonoBehaviour
{
    public GameObject[] bee;
    public Transform[] point;

    public float Ins_time=1;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ball", Ins_time, Ins_time);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void ball()
    {
       int Ramdom_Points=Random.Range(0, point.Length);

        int Random_ball = Random.Range(0, bee.Length);


        Instantiate(bee[Random_ball], point[Ramdom_Points].transform.position, point[Ramdom_Points].transform.rotation);
    }
}

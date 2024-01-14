using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WichTurnFace : MonoBehaviour
{

    public GameObject apple;
    public Transform[] points;

    public float Ins_time = 2;


    public GameObject wiches;
    private Animator ani;
    public static int CanAttack;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        ani=GetComponent<Animator>();
        CanAttack = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;

        if (time < 0)
        {
            ani.SetBool("change", true);
            CanAttack = 1;
           
        }


        if (time < -10)
        {
            time = 6;
        }

        if (time >9)
        {
            ani.SetBool("change", false);
            CanAttack= 0;

            InvokeRepeating("ApppleDown", Ins_time, Ins_time);
        }
    }

    void ApppleDown()
    {
        int Random_points = Random.Range(0, points.Length);

        Instantiate(apple, points[Random_points].transform.position, points[Random_points].transform.rotation);
    }

}

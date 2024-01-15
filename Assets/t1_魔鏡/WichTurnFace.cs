using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WichTurnFace : MonoBehaviour
{

    public GameObject apple;
    public Transform[] points;

    public float Ins_time ;

    public int isAtk;

    public GameObject wiches;
    private Animator ani;
    public static int CanAttack;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        ani=GetComponent<Animator>();
        CanAttack = 0;

        isAtk = 0;

        InvokeRepeating("ApppleDown", Ins_time, Ins_time);
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;

        if (time < 0)
        {
            ani.SetBool("change", true);
            CanAttack = 1;

           // Ins_time = 0;

            isAtk=0;
        }


        if (time < -10)
        {
            time = 6;

            isAtk = 0;
        }

        if (time >5)
        {
            ani.SetBool("change", false);
            CanAttack= 0;

          

            // Ins_time = 5;

            isAtk = 1;
        }
    }

    void ApppleDown()
    {
        if (isAtk == 1)
        {
            int Random_points = Random.Range(0, points.Length);

            Instantiate(apple, points[Random_points].transform.position, points[Random_points].transform.rotation);
        }
    }

}

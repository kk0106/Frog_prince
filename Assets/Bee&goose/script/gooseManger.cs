using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class gooseManger : MonoBehaviour
{
    public GameObject bee;
    public float time;
    private Animator ani;
    private Animator ani2;
    private Animator ani3;
    private Animator ani4;
    private Animator ani5;


    public GameObject gos;
    public GameObject gos2;
    public GameObject gos3;
    public GameObject gos4;
    public GameObject gos5;

    // Start is called before the first frame update
    void Start()
    {
        ani = gos.GetComponent<Animator>();
        ani2 = gos2.GetComponent<Animator>();
        ani3 = gos3.GetComponent<Animator>();
        ani4 = gos4.GetComponent<Animator>();
        ani5 = gos5.GetComponent<Animator>();
        //bee.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

        time -= Time.deltaTime;

        if (time < 0)
        {
            ani.SetBool("attack", true);
            ani2.SetBool("attack", true);
            ani3.SetBool("attack", true);
            ani4.SetBool("attack", true);
            ani5.SetBool("attack", true);

            bee.SetActive(false);
        }
        if(time < -1)
        {
            time = 4;
        }

        if (time == 4&&TriggerBall.isIN==1)
        {
            ani.SetBool("attack", false);
            ani2.SetBool("attack", false);
            ani3.SetBool("attack", false);
            ani4.SetBool("attack", false);
            ani5.SetBool("attack", false);
            bee.SetActive(true);

        }
    }
}

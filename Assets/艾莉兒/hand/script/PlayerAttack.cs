using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public static int PlayerCanAttack;
    public GameObject fort;
    
    public float time;
    public  int PlanX;
    public int PlanZ;
    // Start is called before the first frame update
    void Start()
    {
        fort.SetActive(false);
        PlayerCanAttack = 0;
    }

    // Update is called once per frame
    void Update()
    {
        

      

        if (Attack.anifloat == 2)
        {
            PlayerCanAttack =1 ;
            PlanX = Random.Range(0, 7);
            PlanZ = Random.Range(0, 4);
        }
        if(PlayerCanAttack==1)
        {
            fort.SetActive(true);
            fort.transform.position = new Vector3(27 - 5.5f * PlanX, 0.8843641f, -48 - 6.5f * PlanZ);
            time -=Time.deltaTime;
        }
        if (time < 0)
        {
            fort.SetActive (false);
           PlayerCanAttack=0;
            fort.transform.position = new Vector3(27 , 0.8843641f, -48 );
            time = 5;
        }
    }
}

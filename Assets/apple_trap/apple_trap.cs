using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apple_trap : MonoBehaviour
{


    public GameObject apple;
    public Transform[] points;

    public static int aa;

    public float Ins_time = 2;


    public float spwanTime;
    public float CountTime;

    public Vector3 SpwanPosition;

   // public GameObject apple;
    
    // Start is called before the first frame update
    void Start()
    {
        //estroy(apple, 1f);
        InvokeRepeating("ApppleDown", Ins_time, Ins_time);
    }
    
    // Update is called once per frame
    void Update()
    {
        // OnMouseDown();
        //nvoke("Desroy", 1);

        if (points[1])
        {
            aa = 1;
        }
        if (points[2])
        {
            aa = 2;
        }
        if (points[3])
        {
            aa = 3;
        }
        if (points[4])
        {
            aa = 4;
        }
        if (points[5])
        {
            aa = 5;
        }
        if (points[6])
        {
            aa = 6;
        }


        Debug.Log(aa);
    }
  /*  private void OnMouseDown()
    {

   

        CountTime += Time.deltaTime;
        SpwanPosition=transform.position;
        SpwanPosition.x = Random.Range(22f, 28f);
        SpwanPosition.z = Random.Range(-31.35f,-31.35f);
       
        if (CountTime > spwanTime)
        {
            ccreate();

            CountTime = 0;
          
        }
        
       


        
      //float posx = transform.position.x + Random.Range(-RandomPos + 3, RandomPos - 3);//获取随机X轴坐标

     // float posz = transform.position.z + Random.Range(-RandomPos + 3, RandomPos - 3);//获取随机Z轴坐标

     // Vector3 randomNewPos = new Vector3(posx, transform.position.y, posz);//组合成新的三维坐标

     // Instantiate(apple, randomNewPos, Quaternion.identity);//生成怪物
    }
   private void ccreate()
    {
         Instantiate(apple, SpwanPosition, Quaternion.identity);
        
    }
  */
    void ApppleDown()
    {
        int Random_points = Random.Range(0, points.Length);

        Instantiate(apple, points[Random_points].transform.position, points[Random_points].transform.rotation);
    }

}

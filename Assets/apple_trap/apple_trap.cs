using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apple_trap : MonoBehaviour
{

   

   

    public float spwanTime;
    public float CountTime;

    public Vector3 SpwanPosition;

    public GameObject apple;
    
    // Start is called before the first frame update
    void Start()
    {
       //estroy(apple, 1f);
     
    }

    // Update is called once per frame
    void Update()
    {
        OnMouseDown();
       //nvoke("Desroy", 1);
    }
    private void OnMouseDown()
    {

   

        CountTime += Time.deltaTime;
        SpwanPosition=transform.position;
        SpwanPosition.x = Random.Range(16f, 21f);
        SpwanPosition.z = Random.Range(-32.1f,-31.2f);
       
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
    
    

}

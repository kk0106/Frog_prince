using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewAppleTrap : MonoBehaviour
{
    // Start is called before the first frame update
    public float spwanTime;
    public float CountTime;

    public float GoldAppleTime;

    public Vector3 SpwanPosition;
  

    public GameObject apple;
    public GameObject apple1;

    public int a;

    // Start is called before the first frame update
    void Start()
    {
        //estroy(apple, 1f);
       // a = 1;

    }

    // Update is called once per frame
    void Update()
    {

      /*  if (a == 1)
        {
            SpwanPosition = new Vector3(-20.1f, SpwanPosition.y, -48.2f);
            appleTrap = SpwanPosition;
        }

        if (a == 2)
        {
            SpwanPosition = new Vector3(-20.1f, SpwanPosition.y, -45.8f);
            appleTrap = SpwanPosition;
        }


        if (a == 3)
        {
            SpwanPosition = new Vector3(-20.1f, SpwanPosition.y, -43.6f);
            appleTrap = SpwanPosition;
        }


        if (a == 4)
        {
            SpwanPosition = new Vector3(-17.82f, SpwanPosition.y, -48.2f);
            appleTrap = SpwanPosition;
        }

        if (a == 5)
        {
            SpwanPosition = new Vector3(-17.82f, SpwanPosition.y, -45.8f);
            appleTrap = SpwanPosition;
        }


        if (a == 6)
        {
            SpwanPosition = new Vector3(-17.82f, SpwanPosition.y, -43.6f);
            appleTrap = SpwanPosition;
        }

        if (a == 7)
        {
            SpwanPosition = new Vector3(-15.53f, SpwanPosition.y, -48.2f);
            appleTrap = SpwanPosition;
        }

        if (a == 8)
        {
            SpwanPosition = new Vector3(-15.53f, SpwanPosition.y, -45.8f);
            appleTrap = SpwanPosition;
        }


        if (a == 9)
        {
            SpwanPosition = new Vector3(-15.53f, SpwanPosition.y, -43.6f);
            appleTrap = SpwanPosition;
        }

        if (a == 10)
        {
            SpwanPosition = new Vector3(-13.24f, SpwanPosition.y, -48.2f);
            appleTrap = SpwanPosition;
        }

        if (a == 11)
        {
            SpwanPosition = new Vector3(-13.24f, SpwanPosition.y, -45.8f);
            appleTrap = SpwanPosition;
        }


        if (a == 12)
        {
            SpwanPosition = new Vector3(-13.24f, SpwanPosition.y, -43.6f);
            appleTrap = SpwanPosition;
        }   */

      

        OnMouseDown();
        //nvoke("Desroy", 1);
    }
    private void OnMouseDown()
    {

      GoldAppleTime-=Time.deltaTime;



        CountTime += Time.deltaTime;
        SpwanPosition = transform.position;
          SpwanPosition.x = Random.Range(-20f, -13.24f);
        SpwanPosition.z = Random.Range(-43.6f, -48.2f);

        if (CountTime > spwanTime)
        {
            ccreate();

            CountTime = 0;

            //a = Random.Range(1, 12);
       

        }

        
    }
    private void ccreate()
    {
        Instantiate(apple, SpwanPosition, Quaternion.identity);

        if (GoldAppleTime < 0)
        {
            Instantiate(apple1, SpwanPosition, Quaternion.identity);

            GoldAppleTime = 4;
        }


    }
}

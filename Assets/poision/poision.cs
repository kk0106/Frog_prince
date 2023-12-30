using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poision : MonoBehaviour
{
    public GameObject bubble;
    public Vector3 poision_pos;
    public float x;
    public float z;

    public float positiontime;
    public float currentime;
    // Start is called before the first frame update
    void Start()
    {
        poision_pos=bubble.transform.position;
        x = poision_pos.x;
        z = poision_pos.z;
    }

    // Update is called once per frame
    void Update()
    {
        currentime+=Time.deltaTime;

        x=Random.Range(10.22f,27.64f); 
        z=Random.Range(4.16f,-0.12f);

        

        
        if (currentime > positiontime)
        {
            ccreate();

           currentime = 0;

            //a = Random.Range(1, 12);


        }


    }
    private void ccreate()
    {
        Instantiate(bubble, poision_pos, Quaternion.identity);
    }
}

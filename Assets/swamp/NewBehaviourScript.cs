using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private float x;
    private float y;
    private float z;
    //public Vector3 pos;
    public GameObject a;
    public float time;
    public float b;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x = a.transform.position.x;
        y = a.transform.position.y;
        z=a.transform.position.z;
        if (time >1.5f)
        {
            a.transform.position = new Vector3(x, y+b, z);
        }
        if (time < 1.5f)
        {
            a.transform.position = new Vector3(x, y-b, z);
        }
      ///  a.transform.position = pos;
        
      
        time += Time.deltaTime;
        if(time >= 3)
        {
            time= 0;
        }
    }
}

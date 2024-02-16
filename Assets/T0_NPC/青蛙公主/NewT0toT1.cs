using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewT0toT1 : MonoBehaviour
{
    public GameObject black;
    public GameObject ball;
    public GameObject com;

    public static int a;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
       black.SetActive(false);
       ball.SetActive(false);
        com.SetActive(false);

        a = 0;
    }

    // Update is called once per frame
    void Update()
    {
     
          

        if (a == 1)
        {

              black.SetActive(true);
              time += Time.deltaTime;
        }
       

       

        if(time>1.5)
        {
            com.SetActive(true);
        }

        if (time >6.5)
        {
            ball.SetActive(true);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            a = 1;
        }
    }
}

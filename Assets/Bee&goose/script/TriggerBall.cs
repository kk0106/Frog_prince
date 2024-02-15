using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBall : MonoBehaviour
{
    public GameObject bee1;
    public GameObject bee2;
    public GameObject bee3;
   // public GameObject bee4;
    public GameObject bee5;
    public static int isIN;

    // Start is called before the first frame update
    void Start()
    {
        bee1.SetActive(false); 
        bee2.SetActive(false);
        bee3.SetActive(false);
      //  bee4.SetActive(false);
        bee5.SetActive(false);
        isIN = 0;
    }

    // Update is callled once per frame
    void Update()
    {
        Debug.Log(isIN);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            bee1.SetActive (true);
            bee2.SetActive (true);
            bee3.SetActive (true);
           // bee4.SetActive (true);
            bee5.SetActive (true);
            isIN = 1;
        }
    }
}

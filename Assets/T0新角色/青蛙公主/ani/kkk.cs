using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kkk : MonoBehaviour
{
    public int a;
    public GameObject text1;
    public GameObject text2;
    public  float time;
    // Start is called before the first frame update
    void Start()
    {

        a = 0;
        text1.SetActive(false);
        text2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (a == 1)
        {
            time += Time.deltaTime;
        }

        if(time > 0)
        {
            text1.SetActive (true);

        }

        if (time > 0.3)
        {
            text2 .SetActive (true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            a = 1;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            a = 1;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTrigger : MonoBehaviour
{
    public GameObject cam;
    public GameObject wolf;
    public float time;
    public static int startValue;
    // Start is called before the first frame update
    void Start()
    {
        startValue = 0;
        cam.SetActive(false);
        
    }


    // Update is called once per frame
    void Update()
    {
        if(startValue==1)
        {
            time+=Time.deltaTime;
        }
        if (time >5)
        {
            startValue = 2;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            cam.SetActive(true);

            startValue = 1;
        }
    }
}

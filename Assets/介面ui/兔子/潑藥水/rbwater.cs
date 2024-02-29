using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class rbwater : MonoBehaviour
{
    public GameObject bloom;
    public GameObject player;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        bloom.SetActive(false);
        player.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        time-=Time.deltaTime;


        if (time < 0.7)
        {
            bloom.SetActive(true);
        }

        if (time < 0.67)
        {
            player.SetActive(true);
        }

        if(time < -1.2)
        {
           
            bloom.SetActive(false);
        }
       
        
           
           
        

    }
}

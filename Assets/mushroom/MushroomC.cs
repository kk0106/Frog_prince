using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomC : MonoBehaviour
{
    public float timer;

    public GameObject mushrooma;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.B==1)
        {
            timer -= Time.time;
        }

        if(timer<1)
        {
            mushrooma.SetActive(true);
        }

        if(timer<0)
        {
            timer = 4;
            player.B = 0;
        }
    }
}

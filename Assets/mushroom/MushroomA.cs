using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomA : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.B==1)
        {
            this.gameObject.transform.Rotate(0, 90, 0);
          player.B = 0;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class egg_des : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "wall"||  other.gameObject.tag == "poison")
        {
            Invoke("Des", 2f);
        }
        if ( other.gameObject.tag == "Mushroom" || other.gameObject.tag == "MushroomA" || other.gameObject.tag == "MushroomB" || other.gameObject.tag == "MushroomC" )
        {
            Invoke("Des", 4f);
        }
    }
    private void Des()
    {
        Destroy(this.gameObject);
    }
}

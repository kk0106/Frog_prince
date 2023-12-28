using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class des : MonoBehaviour
{
    public float time;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (time < 0)
        {
            Destroy(this.gameObject);
            time = 0.2f;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "wall"|| other.gameObject.tag == "MushroomA" || other.gameObject.tag == "MushroomC")
        {
           time-=Time.deltaTime;
        }
    }

    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "wall" || other.gameObject.tag == "MushroomA" || other.gameObject.tag == "MushroomC")
        {
            time -= Time.deltaTime;
        }
    }

}

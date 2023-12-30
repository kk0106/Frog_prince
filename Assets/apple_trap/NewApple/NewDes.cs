using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewDes : MonoBehaviour
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
            time = 0.5f;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "wall"  || other.gameObject.tag == "poison")
        {
            time -= Time.deltaTime;
        }

        if(other.gameObject.tag== "mirror")
        {
            this.gameObject.SetActive(false);
        }
    }

    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "wall" || other.gameObject.tag == "MushroomA" || other.gameObject.tag == "MushroomC" || other.gameObject.tag == "poison")
        {
            time -= Time.deltaTime;
        }
    }
}

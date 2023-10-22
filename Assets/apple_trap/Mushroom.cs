using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom : MonoBehaviour
{
    public GameObject cam;
    // Start is called before the first frame update
    void Start()
    {
           cam.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        cam.SetActive (true);
    }

}

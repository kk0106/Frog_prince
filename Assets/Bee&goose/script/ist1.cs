using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ist1 : MonoBehaviour
{
    public GameObject ist11;

    // Start is called before the first frame update
    void Start()
    {
        ist11.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ist11.SetActive(true);
        }
    }
}

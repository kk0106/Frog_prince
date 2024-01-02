using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsInT1 : MonoBehaviour
{
    public GameObject isint1;

    // Start is called before the first frame update
    void Start()
    {
        isint1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    private void OnTriggerEnter(Collider other)
    {
        isint1.SetActive(true);
    }
}

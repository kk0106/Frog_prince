using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedAppleSetting : MonoBehaviour
{
    private BreakableObject breakableObject;
   
    // Start is called before the first frame update
    void Start()
    {
        breakableObject = GetComponent<BreakableObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (breakableObject != null && breakableObject.currentHealth <= 5f)
        {
            this.gameObject.SetActive(false);
        }

    }
}

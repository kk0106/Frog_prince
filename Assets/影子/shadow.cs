using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shadow : MonoBehaviour
{
    public GameObject shadows;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "apple")
        {
            Instantiate(shadows, new Vector3(other.transform.position.x,0.3f,other.transform.position.z),Quaternion.Euler(90,0,0));
        }
    }
}

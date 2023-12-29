using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class airplanUI : MonoBehaviour
{

    public GameObject AirPlanTip;
    public GameObject AirPlanTip1;
    // Start is called before the first frame update
    void Start()
    {
        AirPlanTip.SetActive(false);
        AirPlanTip1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            AirPlanTip.SetActive(true);
            AirPlanTip1 .SetActive(true);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            AirPlanTip.SetActive(true);
            AirPlanTip1.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            AirPlanTip.SetActive(false);
            AirPlanTip1.SetActive(false);
        }
    }
}

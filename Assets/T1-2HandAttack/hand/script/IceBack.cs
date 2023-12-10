using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceBack : MonoBehaviour
{
    public float time;
    public GameObject ice;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!ice.activeInHierarchy)
        {
            time-=Time.deltaTime;
        }


        if (time < 0)
        {
            ice.gameObject.SetActive(true);
        }

        if(GameObject.Find("a") == null)
        {
            Debug.Log("yes");
        }
        else
        {
            Debug.Log("no");
        }
    }
}

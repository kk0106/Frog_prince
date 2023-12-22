using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class end_ant : MonoBehaviour
{
public GameObject a;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (!a.activeInHierarchy)
{
    SceneManager.LoadScene("T1toT2");
}
    }
    
  
}

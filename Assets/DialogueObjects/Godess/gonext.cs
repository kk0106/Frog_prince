using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gonext : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public  void go()
    {
        SceneManager.LoadScene("T1_MermaidDie");
    }

    public void go1()
    {
        SceneManager.LoadScene("T1_NewMermaid");
    }
}

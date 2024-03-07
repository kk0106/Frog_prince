using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class end : MonoBehaviour
{
    public GameObject panel;
    public float time;
    
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (panel.activeInHierarchy)
        {
            time += Time.deltaTime;
        }

        if(time>4)
        {
            SceneManager.LoadScene("Start");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="wolf")
        {
            panel.SetActive(true);
        }
    }
}

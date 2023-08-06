using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gototalk : MonoBehaviour
{
    public GameObject a;
    public GameObject b;
    // Start is called before the first frame update
    void Start()
    {
        a.SetActive(false);
        b.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (a.activeInHierarchy||b.activeInHierarchy)
        {
            if (UserInput.instance.controls.playerControls.talk.WasPressedThisFrame())
            {
                SceneManager.LoadScene(4);
            }
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        other.gameObject.tag = "Player";
        a.SetActive(true);
        b.SetActive(true);
        
    }

    private void OnCollisionExit(Collision other)
    {
        other.gameObject.tag = "Player";
        a.SetActive(false);
            b.SetActive(false);
    }

    
}

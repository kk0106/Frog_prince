using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gototalk1 : MonoBehaviour
{
    public GameObject a;
    // Start is called before the first frame update
    void Start()
    {
        a.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (a.activeInHierarchy)
        {
            if (UserInput.instance.controls.playerControls.talk.WasPressedThisFrame())
            {
                SceneManager.LoadScene(1);
            }
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        other.gameObject.tag = "Player";
        a.SetActive(true);
       
    }

    private void OnCollisionExit(Collision other)
    {
        other.gameObject.tag = "Player";
        a.SetActive(false);
    }

    
}

using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class comic : MonoBehaviour
{
    public float time;
   
    public GameObject ball;
    

    void Start()
    {
     
        ball.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        time += Time.deltaTime;

        if (time > 3)
        {
            ball.SetActive(true);
        }

        if (ball.activeInHierarchy)
        {
            if (UserInput.instance.controls.playerControls.KeepStory.WasPerformedThisFrame())
            {
                SceneManager.LoadScene("T1");
            }
        }
    }
}

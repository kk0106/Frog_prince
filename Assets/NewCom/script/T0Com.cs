using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class T0Com : MonoBehaviour
{

    public GameObject t0;
    public float time;
    public GameObject AIcon;
    // Start is called before the first frame update
    void Start()
    {
       
        AIcon.SetActive(false);
        t0.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time > 4.5)
        {
            t0.SetActive(true);

        }
      
        if (time > 7)
        {
            AIcon.SetActive (true);

                if (UserInput.instance.controls.playerControls.KeepStory.WasPressedThisFrame())
                {
                    SceneManager.LoadScene("Frog");

                time = 0;
                }
        }


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class T0Com : MonoBehaviour
{
    public static float change;
    public GameObject t0;
    public float time;
    //public GameObject AIcon;
    public GameObject penal;
    // Start is called before the first frame update
    void Start()
    {
        change = 0;
       penal.SetActive(false);
       // AIcon.SetActive(false);
        t0.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time > 4.5)
        {
       //     t0.SetActive(true);

        }
      
        /*if (time > 10)
        {
            AIcon.SetActive (true);

                if (UserInput.instance.controls.playerControls.KeepStory.WasPressedThisFrame())
                {
                    SceneManager.LoadScene("Frog");

                time = 0;
                }
        }*/

        if (time > 17.6)
        {


           penal.SetActive(true);

        }

        if (time > 18.05)
        {


            change = 1;
                SceneManager.LoadScene("Frog");

                time = 0;
            
        }
    }
}

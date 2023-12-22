using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BUTTON : MonoBehaviour
{
    public GameObject howplay;
    public static int A;
    // Start is called before the first frame update
    void Start()
    {
        A = 0;
        howplay.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void restartT0()
    {
        if (UserInput.instance.controls.playerControls.uiback.WasReleasedThisFrame())
        {
            SceneManager.LoadScene("Frog");
        }  
    }

    public void restartT11()
    {
        if (UserInput.instance.controls.playerControls.uiback.WasReleasedThisFrame())
        {
            SceneManager.LoadScene("T1");
        }
    }

    public void restartT12()
    {
        if (UserInput.instance.controls.playerControls.uiback.WasReleasedThisFrame())
        {
            SceneManager.LoadScene("T1_Mermaid");
        }
    }

    public void restartT13()
    {
        if (UserInput.instance.controls.playerControls.uiback.WasReleasedThisFrame())
        {
            SceneManager.LoadScene("T1_Clock");
        }
    }

    public void restartT21()
    {
        if (UserInput.instance.controls.playerControls.uiback.WasReleasedThisFrame())
        {
            SceneManager.LoadScene("T2_WOLF");
        }
    }
    public void HOME()
    {
        if (UserInput.instance.controls.playerControls.uiback.WasReleasedThisFrame())
        {
            SceneManager.LoadScene("Start");
        }
       
    }

    public void HowToPlay()
    {
        if (UserInput.instance.controls.playerControls.uiback.WasReleasedThisFrame())
        {
            howplay.SetActive(true);
        }
        
        
        
    }
    public void close()
    {

        if (UserInput.instance.controls.playerControls.uiback.WasReleasedThisFrame())
        {
            howplay.SetActive(false);
        }


    }

    public void next()
    {
        if (UserInput.instance.controls.playerControls.IngameAni.WasReleasedThisFrame())
        {
            SceneManager.LoadScene("T1");
        }
       
    }
    public void frog()
    {
        if (UserInput.instance.controls.playerControls.IngameAni.WasReleasedThisFrame())
        {
            SceneManager.LoadScene("Frog");
        }
    }

    public void GoStartAni()
    {
        if (UserInput.instance.controls.playerControls.startAni.WasReleasedThisFrame())
        {
            SceneManager.LoadScene("StartAni");
            A = 1;
        }
    }
}

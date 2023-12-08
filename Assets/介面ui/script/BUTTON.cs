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
    public void restart()
    {
        SceneManager.LoadScene("Frog");
    }
    public void HOME()
    {
        SceneManager.LoadScene("Start");
    }

    public void HowToPlay()
    {
        
            howplay.SetActive(true);
        
        
    }
    public void close()
    {
        
            howplay.SetActive(false);
        
    }

    public void next()
    {
        if (UserInput.instance.controls.playerControls.IngameAni.WasReleasedThisFrame())
        {
            SceneManager.LoadScene("T1");
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

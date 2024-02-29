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
       
            SceneManager.LoadScene("Frog");
        
    }

    public void restartT11()
    {
       
            SceneManager.LoadScene("T1");
        
    }

    public void restartT12()
    {
        
            SceneManager.LoadScene("T1_NewMermaid");
        
    }

    public void restartT13()
    {
        
            SceneManager.LoadScene("T1_Clock");
        
    }

    public void restartT21()
    {
        
            SceneManager.LoadScene("T2_WOLF");
        
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
        
            SceneManager.LoadScene("T1");
        
       
    }

    public void GoStartAni()
    {
        
            SceneManager.LoadScene("StartAni");
            A = 1;
        
    }
}

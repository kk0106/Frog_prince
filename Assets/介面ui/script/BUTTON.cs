using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BUTTON : MonoBehaviour
{
    public GameObject howplay;
    // Start is called before the first frame update
    void Start()
    {
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
}

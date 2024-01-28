using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManger : MonoBehaviour
{
    [SerializeField] private GameObject _mainMenuCanvaGo;
    [SerializeField] private GameObject _settingMenuCanvaGo;

    private bool isPaused;
    // Start is called before the first frame update
    void Start()
    {
        _mainMenuCanvaGo.SetActive(false);
        _settingMenuCanvaGo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (UserInput.instance.menuOpenCloseInput)
        {
            if (!isPaused)
            {
                Pause();
            }
            else
            {
                Unpause();
            }
        }
    }

    public void Pause()
    {
        isPaused = true;
        Time.timeScale = 0f;


        OnOpenMainMenu();
    }

    public void Unpause()
    {
        isPaused=false;
        Time.timeScale = 1f;

        CloseAllMenu();
    }
    


    private void OnOpenMainMenu()
    {
        _mainMenuCanvaGo.SetActive(true);
        _settingMenuCanvaGo.SetActive(false);
    }


    private void CloseAllMenu()
    {
        _settingMenuCanvaGo.SetActive(false);
        _mainMenuCanvaGo.SetActive(false);
    }
}
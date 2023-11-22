using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uiMenu : MonoBehaviour
{
    public GameObject menu;
    public bool Opened;
    public Button firstResponseButton;
    // Start is called before the first frame update
    void Start()
    {
        menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (UserInput.instance.controls.playerControls.uiTouch.WasPressedThisFrame())
        {
            Opened=!Opened;
            menu.SetActive(Opened);
            firstResponseButton.Select();
        }
       
          
        
    }
    
}

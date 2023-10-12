using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uiMenu : MonoBehaviour
{
    public GameObject menu;
    bool A = true;
    // Start is called before the first frame update
    void Start()
    {
        menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (UserInput.instance.controls.playerControls.uiTouch.WasPressedThisFrame()&&A)
        {
            menu.SetActive(true);
            A=false;
            
        }
       
          
        
    }
    
}

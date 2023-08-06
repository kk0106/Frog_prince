using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using Flower;

using UnityEngine.SceneManagement;

public class shopTalk1 : MonoBehaviour
{
    FlowerSystem fs;
    private int sell=0;
    
    // Start is called before the first frame update
    void Start()
    {
        fs = FlowerManager.Instance.CreateFlowerSystem("defalut", false);

        fs.SetupDialog();
        fs.SetupButtonGroup();
        fs.RegisterCommand("load_scene", (List<string> _params) => { SceneManager.LoadScene(_params[0]); });
        
    }

    // Update is called once per frame
    void Update()
    {
        if (UserInput.instance.controls.playerControls.talk.WasPressedThisFrame())
        {
            Debug.Log("iswork");
           
        }
        


        switch(sell)
        {
            case 0:
              
                fs.ReadTextFromResource("shop");

                break;
            case 1:
               

                fs.SetupButton("��.", () => {
                    // Your code here...
                    fs.Resume(); // Resume system.
                    fs.RemoveButtonGroup(); // Remove the button group.
                });

                fs.SetupButton("����.", () => {
                    // Your code here...
                    fs.Resume(); // Resume system.
                    fs.RemoveButtonGroup(); // Remove the button group.
                });
                break;
        }
    }

       
    

}
    
   



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
    //private int sell=0;
    
    // Start is called before the first frame update
    void Start()
    {
        fs = FlowerManager.Instance.CreateFlowerSystem("defalut", false);

        fs.SetupDialog();
        fs.ReadTextFromResource("shop");
        fs.RegisterCommand("load_scene", (List<string> _params) => { SceneManager.LoadScene(_params[0]); });

        fs.SetupButtonGroup("DefaultButtonUIPrefab");
        Invoke("sell", 10);

    }

    // Update is called once per frame
    void Update()
    {
        if (UserInput.instance.controls.playerControls.talk.WasPressedThisFrame())
        {
            Debug.Log("iswork");
            fs.Next();
        }
        


    }

    void sell()
    {
        fs.SetupButton("½æ.", () => {
            fs.ReadTextFromResource("");
            fs.Resume(); // Resume system.
            fs.RemoveButtonGroup(); // Remove the button group.
        });
        fs.SetupButton("¤£½æ.", () => {
            fs.ReadTextFromResource("");
            fs.Resume(); // Resume system.
            fs.RemoveButtonGroup(); // Remove the button group.
        });
    }

       
    

}
    
   



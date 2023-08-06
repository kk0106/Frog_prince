using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Flower;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Talk : MonoBehaviour
{
    FlowerSystem fs;
    public bool haveShoes;
    private int a=0;

    // Start is called before the first frame update
    void Start()
    {
        fs = FlowerManager.Instance.CreateFlowerSystem("defalut", false);

        fs.SetupDialog();
          fs.ReadTextFromResource("cinderella");
        Invoke("shoes", 10);
        fs.RegisterCommand("load_scene", (List<string> _params) => { SceneManager.LoadScene(_params[0]); });
        //shoes();


     

    }

    // Update is called once per frame
    void Update()
    {
        if (UserInput.instance.controls.playerControls.talk.WasPressedThisFrame())
        {
            fs.Next();

        }


    }
  
    void shoes()
    {
       fs.ReadTextFromResource("cinderella");
        if (haveShoes)
        {
            fs.ReadTextFromResource("haveshoes");
        }
        else
        {
            fs.ReadTextFromResource("nothaveshoes");
        }
    }
}

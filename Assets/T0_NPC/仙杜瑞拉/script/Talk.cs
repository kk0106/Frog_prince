using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Flower;
using UnityEngine.SceneManagement;

public class Talk : MonoBehaviour
{
    FlowerSystem fs;

    // Start is called before the first frame update
    void Start()
    {
        fs = FlowerManager.Instance.CreateFlowerSystem("defalut", false);

        fs.SetupDialog();
        fs.ReadTextFromResource("cinderella");
        fs.RegisterCommand("load_scene", (List<string> _params) => { SceneManager.LoadScene(_params[0]); });
    }

    // Update is called once per frame
    void Update()
    {
        if (UserInput.instance.controls.playerControls.talk.WasPressedThisFrame())
        {
            fs.Next();
        }
    }
}

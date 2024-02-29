using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToPlay : MonoBehaviour
{
    public GameObject panel;
    public GameObject settingPanel;
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
        settingPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (panel.activeInHierarchy)
        {
            if(UserInput.instance.controls.playerControls.howplay.WasPerformedThisFrame())
            {
                panel.SetActive(false);
                settingPanel.SetActive(true);
            }
        }
    }
}

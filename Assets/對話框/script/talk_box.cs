using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class talk_box : MonoBehaviour
{
    public GameObject Button;
    public GameObject TalkUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Button.activeInHierarchy && UserInput.instance.controls.playerControls.talk.WasPressedThisFrame())
        {
            TalkUI.SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Button.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        Button.SetActive(false); 
    }
}

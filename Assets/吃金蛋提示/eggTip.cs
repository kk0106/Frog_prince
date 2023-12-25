using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eggTip : MonoBehaviour
{
    public GameObject panel;
    public float time;
    
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (panel.activeInHierarchy)
        {
            time-=Time.deltaTime;
        }

        if (time < 0)
        {
            Time.timeScale = 0;
        }

        if (UserInput.instance.controls.playerControls.uiChoose.WasPressedThisFrame()){
            Time.timeScale = 1;
            time = 0.8f;
            panel.SetActive(false);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            panel.SetActive(true);
            
        }
    }

  
}

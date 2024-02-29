using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eggTip : MonoBehaviour
{
    public GameObject panel;
    public static int IsTip; 
    
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
        IsTip = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (panel.activeInHierarchy)
        {
            IsTip = 1;
        }

       

        if (UserInput.instance.controls.playerControls.KeepStory.WasPressedThisFrame()){
           
            panel.SetActive(false);
            IsTip = 0;
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ui : MonoBehaviour
{
    public GameObject hint;
    public GameObject hintText;
    
    //public GameObject move_hint;
    //public GameObject jump_hint;
    //public GameObject talk_hint;
    //public GameObject swing_hint;
    //public GameObject jumphook_hint;
    // Start is called before the first frame update
    void Start()
    {
        hintText.SetActive(false);
        hint.SetActive(false);

        //move_hint.SetActive(false); 
        //jump_hint.SetActive(false);     
        //talk_hint.SetActive(false); 
        //swing_hint.SetActive(false);
        //jumphook_hint.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    private void OnTriggerEnter(Collider other)
    {
      
            hintText.SetActive(true);
            hint.SetActive(true);

            // move_hint.SetActive(true);
            // jump_hint.SetActive(true);
            //talk_hint.SetActive(true);
            //swing_hint.SetActive(true);
            //jumphook_hint.SetActive(true);
        
    }

    private void OnTriggerExit(Collider other)
    {
            hintText.SetActive(false);
            hint.SetActive(false);

            //move_hint.SetActive(false);
            //jump_hint.SetActive(false);
            // talk_hint.SetActive(false);
            // swing_hint.SetActive(false);
            //  jumphook_hint.SetActive(false);
        
    }
}

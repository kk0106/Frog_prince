using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ui : MonoBehaviour
{
    public GameObject hint;
    public GameObject hint2;
    public GameObject hintText;
    public GameObject light;

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
        hint2.SetActive(false);
            light.SetActive(false);

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
        if (other.CompareTag("Player"))
        {
            hintText.SetActive(true);
                hint2.SetActive(true);
            hint.SetActive(true);
                light.SetActive(true);
            // Additional hints or actions when the player enters
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            hintText.SetActive(false);
            hint2.SetActive(false);
            hint.SetActive(false);
                light.SetActive(false);
            // Additional hints or actions when the player exits
        }
    }
}
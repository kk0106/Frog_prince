using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    [Header("visual cube")]
    [SerializeField] private GameObject visualcube;

    [Header("INK JSON")]
    [SerializeField] private TextAsset inkJSON;

    private bool playerInRange;

    private void Awake()
    {
        playerInRange = false;
        visualcube.SetActive(false);
    }

    private void Update()
    {
        if (playerInRange&& !DialogueManger.GetInstance().DialogueIsPlaying)
        {
            visualcube.SetActive(true);
        }
        else 
        { 
            visualcube.SetActive(false); 
        }

        if (UserInput.instance.controls.playerControls.talk.WasPressedThisFrame()&&visualcube.activeInHierarchy)
        {
            DialogueManger.GetInstance().EnterDialogueMode(inkJSON);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Player")
        {
            playerInRange=true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        playerInRange=false;
    }
}

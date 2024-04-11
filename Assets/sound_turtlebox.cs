using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound_turtlebox : MonoBehaviour
{
    AudioManager audioManager;
    private bool hasPlayedSFX = false;

    // Start is called before the first frame update
    private void awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !hasPlayedSFX)
        {
            AudioManager.Instance.PlaySFX(AudioManager.Instance.turtleCry);
            hasPlayedSFX = true;
          

           
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigOnce : MonoBehaviour
{
    [SerializeField] AudioSource SFXSource;
    AudioManager audioManager;
    public AudioClip custom;
    private bool hasPlayedSFX = false;
    // Start is called before the first frame update
    void awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")&&!hasPlayedSFX)
        {
                        
                SFXSource.PlayOneShot(custom);
            hasPlayedSFX = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameObject.SetActive(false);
        }
    }
}

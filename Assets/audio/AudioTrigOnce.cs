using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigOnce : MonoBehaviour
{
    AudioManager audioManager;
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
        if (other.CompareTag("Player"))
        {
            AudioManager.Instance.PlaySFX(AudioManager.Instance.witch);
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

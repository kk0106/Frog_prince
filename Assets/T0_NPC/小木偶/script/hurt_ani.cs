using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class hurt_ani : MonoBehaviour
{
    public Animator animator;
    private BreakableObject breakableObject;
    AudioManager audioManager;
    private bool hasFunctionBeenCalled = false;
    private bool hasFunctionBeenCalled2 = false;
    private bool hasFunctionBeenCalled3 = false;
    // Start is called before the first frame update
    void Start()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
        breakableObject = GetComponent<BreakableObject>();

        // Ensure that the animator reference is assigned in the Inspector
       // if (animator == null)
       // {
          // Debug.LogError("Animator reference is not assigned in the Inspector.");
       // }
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the health is below the threshold and the animation hasn't played
        if (breakableObject != null && breakableObject.currentHealth <= 5f)
        {
            animator.SetBool("hurt2", true);
            
            if (!hasFunctionBeenCalled)
            {
            AudioManager.Instance.PlaySFX(AudioManager.Instance.smallcrack);
            hasFunctionBeenCalled = true;
            }
           return; 
        }

        if (breakableObject != null && breakableObject.currentHealth <= 10f)
        {
            animator.SetBool("hurt", true);
           if (!hasFunctionBeenCalled2)
            {
            AudioManager.Instance.PlaySFX(AudioManager.Instance.smallcrack);
            hasFunctionBeenCalled2 = true;
            }
        }
        
    }
}
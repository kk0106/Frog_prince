using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class hurt_ani : MonoBehaviour
{
    public Animator animator;
    private BreakableObject breakableObject;

    // Start is called before the first frame update
    void Start()
    {
        // You might want to get the BreakableObject component here if needed
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
            return;
        }

        if (breakableObject != null && breakableObject.currentHealth <= 10f)
        {
            animator.SetBool("hurt", true);
        }
    }
}
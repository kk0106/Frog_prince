using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hammerbro : MonoBehaviour
{
    public GameObject hammerPrefab;
    public Transform throwPoint;
    public float throwForce = 10f;
    public float jumpForce = 5f;
    public float jumpCooldown = 2f;
    public float throwCooldown = 1.5f;

    private Rigidbody rb;
    private Animator animator;
    private bool isJumping = false;
    private bool canThrow = true;
    private bool throwingEnabled = true; // Added variable to track throwing enabled state

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();

        // Start automatic jumping and throwing routines
        InvokeRepeating(nameof(Jump), jumpCooldown, jumpCooldown);
        InvokeRepeating(nameof(ThrowHammer), throwCooldown, throwCooldown);
    }

    private void ThrowHammer()
    {
        if (!throwingEnabled) return; // Check if throwing is enabled

        // Instantiate a hammer projectile
        GameObject hammer = Instantiate(hammerPrefab, throwPoint.position, Quaternion.identity);

        // Apply force to the hammer to throw it
        Rigidbody hammerRb = hammer.GetComponent<Rigidbody>();
        hammerRb.AddForce(transform.right * throwForce, ForceMode.Impulse);
    }

    private void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    public void SetThrowingEnabled(bool enabled)
    {
        throwingEnabled = enabled;
    }
}

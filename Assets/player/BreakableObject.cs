using UnityEngine;

public class BreakableObject : MonoBehaviour
{
    public float maxHealth = 100f;
    private float currentHealth;

    // Add any additional variables and references as needed

    void Start()
    {
        currentHealth = maxHealth;
    }

    // Apply damage to the breakable object
     public void ApplyDamage(float damageAmount)
    {
        currentHealth -= damageAmount;

        if (currentHealth <= 0f)
        {
            Break();
        }
    }

    // Implement breaking behavior here
    private void Break()
    {
        // Add any logic you want for the object breaking (e.g., play animations, destroy object, etc.)

        // For example, you can destroy the object when it breaks
        Destroy(gameObject);
    }
}
using UnityEngine;

public class RotatingPlatform : MonoBehaviour
{
    public float rotationSpeed = 30f; // Adjust the speed as needed

    private void Update()
    {
        // Calculate the target rotation to keep the platform's up vector aligned with the world up vector
        Vector3 worldUp = Vector3.up;
        Quaternion targetRotation = Quaternion.LookRotation(transform.forward, worldUp);

        // Smoothly rotate the platform towards the target rotation
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
    }
}

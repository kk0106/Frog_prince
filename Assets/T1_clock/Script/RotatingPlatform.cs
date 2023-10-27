using UnityEngine;

public class RotatingPlatform : MonoBehaviour
{
    public float rotationSpeed = 30f; // Adjust the speed as needed
    public float upAngleThreshold = 10f; // Adjust the angle threshold

    private void Update()
    {
        if (Vector3.Angle(transform.up, Vector3.up) < upAngleThreshold)
        {
            // Rotate around the local Y-axis
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime, Space.Self);
        }
    }
}
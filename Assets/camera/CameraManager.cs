using UnityEngine;
using System.Collections;

public class CameraManager : MonoBehaviour
{
    private Camera mainCamera;
    private Vector3 originalPosition;
    private Quaternion originalRotation;
    private bool isMovingCamera;

    public static CameraManager Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
        mainCamera = Camera.main;
        originalPosition = mainCamera.transform.position;
        originalRotation = mainCamera.transform.rotation;
    }

    public void PositionCameraForDialogue(Vector3 npcPosition)
    {
        if (!isMovingCamera)
        {
            StartCoroutine(MoveCameraToNpcPosition(npcPosition));
        }
    }

    private IEnumerator MoveCameraToNpcPosition(Vector3 npcPosition)
    {
        isMovingCamera = true;

        float moveDuration = 1f; // Adjust this duration as needed for smooth movement

        Vector3 startingPosition = mainCamera.transform.position;
        Quaternion startingRotation = mainCamera.transform.rotation;

        Vector3 targetPosition = CalculateCameraPositionForNpc(npcPosition);

        float elapsedTime = 0f;

        while (elapsedTime < moveDuration)
        {
            mainCamera.transform.position = Vector3.Lerp(startingPosition, targetPosition, elapsedTime / moveDuration);
            mainCamera.transform.rotation = Quaternion.Slerp(startingRotation, Quaternion.LookRotation(npcPosition - mainCamera.transform.position), elapsedTime / moveDuration);

            elapsedTime += Time.deltaTime;
            yield return null;
        }

        mainCamera.transform.position = targetPosition;

        isMovingCamera = false;
    }

    private Vector3 CalculateCameraPositionForNpc(Vector3 npcPosition)
    {
        // Calculate a position where the NPC is in the center of the camera view
        // You can adjust this position based on your camera and NPC setup
        // For example, you might want to raise the y-coordinate to focus on the NPC's head
        return npcPosition + new Vector3(0f, 2f, -5f);
    }

    public void ResetCamera()
    {
        if (!isMovingCamera)
        {
            StartCoroutine(MoveCameraSmoothly(originalPosition, originalRotation));
        }
    }

    private IEnumerator MoveCameraSmoothly(Vector3 targetPosition, Quaternion targetRotation)
    {
        isMovingCamera = true;

        float elapsedTime = 0f;
        float moveDuration = 1f; // Adjust this duration as needed for smooth movement

        Vector3 startingPosition = mainCamera.transform.position;
        Quaternion startingRotation = mainCamera.transform.rotation;

        while (elapsedTime < moveDuration)
        {
            mainCamera.transform.position = Vector3.Lerp(startingPosition, targetPosition, elapsedTime / moveDuration);
            mainCamera.transform.rotation = Quaternion.Slerp(startingRotation, targetRotation, elapsedTime / moveDuration);

            elapsedTime += Time.deltaTime;
            yield return null;
        }

        mainCamera.transform.position = targetPosition;
        mainCamera.transform.rotation = targetRotation;

        isMovingCamera = false;
    }
}

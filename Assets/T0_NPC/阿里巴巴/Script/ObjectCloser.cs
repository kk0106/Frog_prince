using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ObjectCloser : MonoBehaviour
{
    public RawImage OriArLee;
    public RawImage SadArlee;
    public RawImage HappyArlee;
    public float closeDuration = 3.0f;

    public void OnHappyArleeClick()
    {
        StartCoroutine(ShowObjectForDuration(HappyArlee, closeDuration));
    }

    public void OnSadArleeClick()
    {
        StartCoroutine(ShowObjectForDuration(SadArlee, closeDuration));
    }

    private IEnumerator ShowObjectForDuration(RawImage image, float duration)
    {
        // Close the original object (OriArLee)
        OriArLee.gameObject.SetActive(false);

        // Activate the specified object
        image.gameObject.SetActive(true);

        // Wait for the specified duration
        yield return new WaitForSeconds(duration);

        // Deactivate or close the specified object
        image.gameObject.SetActive(false);

        // Activate the original object (OriArLee)
        OriArLee.gameObject.SetActive(true);
    }
}
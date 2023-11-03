using UnityEngine;
using TMPro;

public class SyncTextMeshPro : MonoBehaviour
{
    public GameObject sourceTextMeshPro; // Reference to the GameObject containing the source TextMeshPro
    public GameObject targetTextMeshPro; // Reference to the GameObject containing the target TextMeshPro

    void Update()
    {
        // Check if the source TextMeshPro and target TextMeshPro exist
        if (sourceTextMeshPro != null && targetTextMeshPro != null)
        {
            TMP_Text sourceText = sourceTextMeshPro.GetComponent<TMP_Text>();
            TMP_Text targetText = targetTextMeshPro.GetComponent<TMP_Text>();

            // Check if the TextMeshPro components exist
            if (sourceText != null && targetText != null)
            {
                // Set the target TextMeshPro's text to match the source TextMeshPro's text
                targetText.text = sourceText.text;
            }
        }
    }
}
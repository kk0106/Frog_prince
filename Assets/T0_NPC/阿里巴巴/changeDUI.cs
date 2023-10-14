using System.Diagnostics;
using UnityEngine;

public class changeDUI : MonoBehaviour
{
    public player componentToModify;
    public DialogueUI newDialogueUI;
    public DialogueUI defaultDialogueUI;


    private void OnTriggerEnter(Collider other)
    {
        // Check if the entering collider has the tag "Player"
        if (other.CompareTag("Player"))
        {
            // Modify the component's DialogueUI using the new DialogueUI
            componentToModify.SetDialogueUI(newDialogueUI);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Check if the exiting collider has the tag "Player"
        if (other.CompareTag("Player"))
        {
            // Reset or stop modifying when the collider is exited
            componentToModify.SetDialogueUI(defaultDialogueUI);  // Or reset to the default UI
        }
    }
}
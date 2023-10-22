using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DialogueUI : MonoBehaviour
{
    [SerializeField] private GameObject dialogueBox;
    [SerializeField] private GameObject ShopBG;
    [SerializeField] private TMP_Text textLabel;
    [SerializeField] private Button[] buttonsToDisable;

    public bool IsOpen { get; private set; }

    private DialogueResponseEvents[] ResponseEvents;
    private ResponseHandler responseHandler;
    private TypewriterEffect typewriterEffect;

    private void Start()
    {
        typewriterEffect = GetComponent<TypewriterEffect>();
        responseHandler = GetComponent<ResponseHandler>();
        CloseDialogueBox();
    }

    public void ShowDialogue(DialogueObject dialogueObject)
    {
        IsOpen = true;

        if (dialogueObject.IsShopInteraction)// Logic to handle shop/shopkeeper interaction                                        
        {
            ShopBG.gameObject.SetActive(true);
            foreach (var button in buttonsToDisable)
            {
                button.interactable = false;
            }
            
            foreach (DialogueResponseEvents responseEvents in ResponseEvents)
            {
                if (responseEvents.DialogueObject == dialogueObject)
                {
                    responseHandler.AddResponseEvents(responseEvents.Events);
                    break;
                }
            }
        }
        else
        {    // Display the responses based on saved ResponseEvents
            foreach (DialogueResponseEvents responseEvents in ResponseEvents)
            {
                if (responseEvents.DialogueObject == dialogueObject)
                {
                    responseHandler.AddResponseEvents(responseEvents.Events);
                    break;
                }
            }
        }
            dialogueBox.SetActive(true);
            StartCoroutine(StepThroughDialogue(dialogueObject));

        
    }

    public void AddResponseEvents(ResponseEvent[] responseEvents)
    {
        responseHandler.AddResponseEvents(responseEvents);
    }

    public void CloseShopDialogueBox()
    {
        IsOpen = true;
        dialogueBox.SetActive(false);
        textLabel.text = string.Empty;

        foreach (var button in buttonsToDisable)
        {
            button.interactable = true;
        }

        ResponseEvents = null;
        
        if (buttonsToDisable.Length > 0)
        {
            EventSystem.current.SetSelectedGameObject(buttonsToDisable[0].gameObject);
        }
    }
    public void CloseDialogueBox()
    {
        IsOpen = false;
        dialogueBox.SetActive(false);
        textLabel.text = string.Empty;
        
        foreach (var button in buttonsToDisable)
        {
            button.interactable = true;
        }
        ShopBG.gameObject.SetActive(false);
        ResponseEvents = null;  // Reset response events
    }

    public void PassDialogueLoopEvents(DialogueResponseEvents[] events)
    {
        ResponseEvents = events;
    }

    private IEnumerator StepThroughDialogue(DialogueObject dialogueObject)
    {
        for (int i = 0; i < dialogueObject.Dialogue.Length; i++)
        {
            string dialogue = dialogueObject.Dialogue[i];

            yield return RunTypingEffect(dialogue);

            textLabel.text = dialogue;

            if (i == dialogueObject.Dialogue.Length - 1 && dialogueObject.HasResponses) break;

            yield return null;
            yield return new WaitUntil(() => UserInput.instance.controls.playerControls.talk.WasPressedThisFrame());
        }
        if (dialogueObject.IsShopInteraction)
        {
            if (dialogueObject.HasResponses)
            {
                responseHandler.ShowResponses(dialogueObject.Responses);
            }
            else
            {
                CloseShopDialogueBox();
            }
        }
        else
        {

        
            if (dialogueObject.HasResponses)
        {
            responseHandler.ShowResponses(dialogueObject.Responses);
        }
        else
        {
            CloseDialogueBox();
        }
        }
    }

    private IEnumerator RunTypingEffect(string dialogue)
    {
        typewriterEffect.Run(dialogue, textLabel);

        while (typewriterEffect.IsRunning)
        {
            yield return null;

            if (UserInput.instance.controls.playerControls.talk.WasPressedThisFrame())
            {
                typewriterEffect.Stop();
            }
        }
    }
}


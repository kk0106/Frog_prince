using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Diagnostics;
using System;

public class ResponseHandler : MonoBehaviour
{
    [SerializeField] private RectTransform responseBox;
    [SerializeField] private RectTransform responseButtonTemplate;
    [SerializeField] private RectTransform responseContainer;
    [SerializeField] private InventoryManager inventoryManager;

    private DialogueUI dialogueUI;
    private ResponseEvent[] responseEvents;
    private bool waitForShopInput = false;

    private Button firstResponseButton;

    public Button FirstResponseButton => firstResponseButton;

    private List<GameObject> tempResponseButtons = new List<GameObject>();

    private void Start()
    {
        dialogueUI = GetComponent<DialogueUI>();
    }

    public void AddResponseEvents(ResponseEvent[] responseEvents)
    {
        this.responseEvents = responseEvents;
    }

    public void ShowResponses(Response[] responses)
    {
        float responseBoxHeight = 0;

        for (int i = 0; i < responses.Length; i++)
        {
            Response response = responses[i];
            int responseIndex = i;

            GameObject responseButton = Instantiate(responseButtonTemplate.gameObject, responseContainer);
            responseButton.gameObject.SetActive(true);
            responseButton.GetComponent<TMP_Text>().text = response.ResponseText;

            // Check if the response requires an item
            if (response.NeedItem)
            {
                if (InventoryManager.HasItem(response.itemID))
                {
                    UnityEngine.Debug.Log("Item is present. Enabling button.");
                    responseButton.GetComponent<Button>().interactable = true;
                }
                else
                {
                    UnityEngine.Debug.Log("Item is not present. Disabling button.");
                    responseButton.GetComponent<Button>().interactable = false;
                }
            }

            responseButton.GetComponent<Button>().onClick.AddListener(() => OnPickedResponse(response, responseIndex));

            if (i == 0)
            {
                firstResponseButton = responseButton.GetComponent<Button>();
                firstResponseButton.Select(); // Highlight the first response button
            }

            tempResponseButtons.Add(responseButton);

            responseBoxHeight += responseButtonTemplate.sizeDelta.y;
        }
        responseBox.sizeDelta = new Vector2(responseBox.sizeDelta.x, responseBoxHeight);
        responseBox.gameObject.SetActive(true);

        // Check if it's a shop interaction
        if (responses.Length > 0 && responses[0].DialogueObject != null && responses[0].DialogueObject.IsShopInteraction)
        {
            waitForShopInput = true;
        }
    }

    void Update()
    {
        // Check for shop input if waiting
        if (waitForShopInput)
        {
            // Replace this with your actual input handling code
            if (UserInput.instance.controls.playerControls.Sell.WasPressedThisFrame())
            {
                // Handle "yes" input
                HandleShopInput(true);
            }
            else if (UserInput.instance.controls.playerControls.notsell.WasPressedThisFrame())
            {
                // Handle "no" input
                HandleShopInput(false);
            }
        }
    }

    private void HandleShopInput(bool isYes)
    {
        // Handle shop input based on isYes
        // For example, you can invoke a specific response event or perform other actions

        // Reset the flag after handling the input
        waitForShopInput = false;

        // Find the button associated with the "yes" or "no" response
        Button shopButton = FindShopButton(isYes);

        // Check if the button is found and has an onClick event
        if (shopButton != null && shopButton.onClick != null)
        {
            // Invoke the onClick event programmatically
            shopButton.onClick.Invoke();
        }
    }

    private Button FindShopButton(bool isYes)
    {
        // Assuming you have a way to determine which button corresponds to "yes" or "no"
        // You might need to adjust this logic based on your UI structure

        // For example, you can check the text of the buttons
        string buttonTextToFind = isYes ? "Yes" : "No";

        foreach (var button in tempResponseButtons)
        {
            TMP_Text buttonText = button.GetComponentInChildren<TMP_Text>();

            if (buttonText != null && buttonText.text.Equals(buttonTextToFind, StringComparison.OrdinalIgnoreCase))
            {
                return button.GetComponent<Button>();
            }
        }

        return null;
    }

    private void OnPickedResponse(Response response, int responseIndex)
    {
        responseBox.gameObject.SetActive(false);

        foreach (GameObject button in tempResponseButtons)
        {
            Destroy(button);
        }
        tempResponseButtons.Clear();

        if (responseEvents != null && responseIndex < responseEvents.Length && responseEvents[responseIndex] != null)
        {
            responseEvents[responseIndex].OnPickedResponse?.Invoke();
        }

        responseEvents = null;

        if (response.DialogueObject)
        {
            if (response.DialogueObject.IsShopInteraction)
            {
                dialogueUI.ShowDialogue(response.DialogueObject);
            }
            else
            {
                dialogueUI.ShowDialogue(response.DialogueObject);
            }
        }
        else
        {
            dialogueUI.CloseDialogueBox();
        }
    }
}
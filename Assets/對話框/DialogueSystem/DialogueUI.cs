using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DialogueUI : MonoBehaviour
{
    [SerializeField] private GameObject dialogueBox;
   // [SerializeField] private GameObject ShopBG;
   // [SerializeField] private TMP_Text characterNameText;
    [SerializeField] private TMP_Text textLabel;
   // [SerializeField] private Button[] buttonsToDisable;
    //[SerializeField] private GameObject talkUI;
    //public GameObject godness;


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
        //talkUI.SetActive(false);
        //if (dialogueObject.IsShopInteraction)// Logic to handle shop/shopkeeper interaction                                        
        {
            //ShopBG.gameObject.SetActive(true);
            //foreach (var button in buttonsToDisable)
            //{
            //    button.interactable = false;
            //}
            
            foreach (DialogueResponseEvents responseEvents in ResponseEvents)
            {
                if (responseEvents.DialogueObject == dialogueObject)
                {
                    responseHandler.AddResponseEvents(responseEvents.Events);
                    break;
                }
            }

        }
        //else
        //{    // Display the responses based on saved ResponseEvents
           // foreach (DialogueResponseEvents responseEvents in ResponseEvents)
            //{
               // if (responseEvents.DialogueObject == dialogueObject)
               // {
               //     responseHandler.AddResponseEvents(responseEvents.Events);
               //     break;
              //  }
          //  }
       // }
       // characterNameText.text = dialogueObject.CharacterName;
        dialogueBox.SetActive(true);
            StartCoroutine(StepThroughDialogue(dialogueObject));

       
    }

    public void AddResponseEvents(ResponseEvent[] responseEvents)
    {
        responseHandler.AddResponseEvents(responseEvents);
    }

   // public void CloseShopDialogueBox()
   // {
    //    IsOpen = true;
     //   dialogueBox.SetActive(false);
    //    textLabel.text = string.Empty;
       // characterNameText.text = string.Empty;

    //    foreach (var button in buttonsToDisable)
    //    {
    //        button.interactable = true;
    //    }

    //    ResponseEvents = null;
        
     //   if (buttonsToDisable.Length > 0)
      //  {
     //       EventSystem.current.SetSelectedGameObject(buttonsToDisable[0].gameObject);
     //   }
   // }
    public void CloseDialogueBox()
    {
        IsOpen = false;
       // talkUI.SetActive(true);
        dialogueBox.SetActive(false);
        textLabel.text = string.Empty;
       // characterNameText.text = string.Empty;


       // foreach (var button in buttonsToDisable)
        //{
        //    button.interactable = true;
        //}
       // ShopBG.gameObject.SetActive(false);
        ResponseEvents = null;  // Reset response events
    }

    public void PassDialogueLoopEvents(DialogueResponseEvents[] events)
    {
        ResponseEvents = events;
    }

    private IEnumerator StepThroughDialogue(DialogueObject dialogueObject)
    {
        string currentCharacterName = dialogueObject.CharacterName;

        for (int i = 0; i < dialogueObject.Dialogue.Length; i++)
        {
            string dialogue = dialogueObject.Dialogue[i];

            // Check if the character name has changed
            //if (dialogueObject.CharacterName != currentCharacterName)
          //  {
            //    currentCharacterName = dialogueObject.CharacterName;
             //   characterNameText.text = currentCharacterName; // Update the displayed character name
            //}

            yield return RunTypingEffect(dialogue);

            textLabel.text = dialogue;

            if (i == dialogueObject.Dialogue.Length - 1 && dialogueObject.HasResponses)
            {
                // Check if the player pressed the "talk" button before showing responses
                yield return new WaitUntil(() => UserInput.instance.controls.playerControls.talk.WasPressedThisFrame());
                responseHandler.ShowResponses(dialogueObject.Responses);
                break;
            }

            yield return null;
            yield return new WaitUntil(() => UserInput.instance.controls.playerControls.talk.WasPressedThisFrame());
        }

       // if (dialogueObject.IsShopInteraction)
       // {
        //    if (!dialogueObject.HasResponses)
         //   {
       //         CloseShopDialogueBox();
        //    }
        //}
        //else
       // {
            if (!dialogueObject.HasResponses)
            {
                CloseDialogueBox();
            }
        //}
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


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class DialogueManger : MonoBehaviour
{
    [Header("Dialogue UI")]

    [SerializeField] private GameObject DialoguePanel;

    [SerializeField] public TextMeshProUGUI DialogueText;


    [SerializeField] private TextMeshProUGUI displayNameText;


    [Header("Choices UI")]

    [SerializeField] private GameObject[] choices;

    private TextMeshProUGUI[] ChoicesText;

    private Story currentStory;

    public bool DialogueIsPlaying { get; private set; }


    private static DialogueManger instance;


    private const string SPEAKER_TAG = "speaker";

    private const string PORTRAIT_TAG = "portrait";

    private const string LAYOUT_TAG = "layout";

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("found more than one dialogue manger in the scene. ");

        }
        instance = this;
    }


    public static DialogueManger GetInstance()
    {
        return instance;
    }

    private void Start()
    {
        DialogueIsPlaying = false;
        DialoguePanel.SetActive(false);

        //獲取所有選項文字
        ChoicesText = new TextMeshProUGUI[choices.Length];
        int index = 0;
        foreach (GameObject choice in choices)
        {
            ChoicesText[index] = choice.GetComponentInChildren<TextMeshProUGUI>();
            index++;
        }
    }

    private void Update()
    {
        if (!DialogueIsPlaying)
        {
            return;
        }

        if (currentStory.currentChoices.Count==0
            &&UserInput.instance.controls.playerControls.talk.WasPressedThisFrame())
        {
            ContinueStory();
        }
    }

    public void EnterDialogueMode(TextAsset inkJSON)
    {
        currentStory = new Story(inkJSON.text);
        DialogueIsPlaying = true;
        DialoguePanel.SetActive(true);

        ContinueStory();
    }

    private IEnumerator ExitDialogueMode()
    {
        yield return new WaitForSeconds(0.2f);

        DialogueIsPlaying = false;
        DialoguePanel.SetActive(false);
        DialogueText.text = "";
    }

    private void ContinueStory()
    {
        if (currentStory.canContinue)
        {
            DialogueText.text = currentStory.Continue();

            DisplayChoices();

            HandleTags(currentStory.currentTags);
        }
        else
        {
            StartCoroutine(ExitDialogueMode());
        }

    }

    private void HandleTags(List<string> currentTags)
    {
        foreach (string tag in currentTags)
        {
            string[] splitsTag = tag.Split(':');
            if (splitsTag.Length != 2)
            {
                Debug.LogError("tag could not be appropriately parsed:" + tag);
            }
            string tagKey = splitsTag[0].Trim();
            string tagValue = splitsTag[1].Trim();


            switch(tagKey)
            {
                case SPEAKER_TAG:
                    displayNameText.text = tagValue;
                    break;
                case PORTRAIT_TAG:
                    Debug.Log("portrait=" + tagValue);
                    break;
                case LAYOUT_TAG:
                    Debug.Log("layout=" + tagValue);
                    break;
                default:
                    Debug.LogWarning("tag came in but isn't currently being handle:" + tag);
                    break;
            }
        }
    }

    private void DisplayChoices()
    {
        List<Choice> currentChoices = currentStory.currentChoices;

        if(currentChoices.Count > choices.Length)
        {
            Debug.LogError("more choices were given than ui can support.number of choices can given:" + currentChoices.Count);
        }
        int index = 0; // 初始化索引

        foreach (Choice choice in currentChoices)
        {
            if (index < choices.Length) // 檢查索引是否在範圍內
            {
                choices[index].gameObject.SetActive(true);
                ChoicesText[index].text = choice.text;
                index++;
            }
            else
            {
                // 如果選擇數量超出 choices 數組的長度，可能顯示錯誤消息或執行其他適當的操作
                Debug.LogError("選擇數量超出範圍");
                break; // 停止迭代，以免引發索引超出範圍的異常
            }
        }

        for (int i =index ; i < choices.Length; i++)
        {
            choices[i].gameObject.SetActive(false);
        }

        StartCoroutine(SelectFirstChoice());
    }

    private IEnumerator SelectFirstChoice()
    {
        EventSystem.current.SetSelectedGameObject(null);
        yield return new WaitForEndOfFrame();
        EventSystem.current.SetSelectedGameObject(choices[0].gameObject);
    }

    public void MakeChoice(int choiceIndex)
    {
        currentStory.ChooseChoiceIndex(choiceIndex);
        ContinueStory();
    }
}

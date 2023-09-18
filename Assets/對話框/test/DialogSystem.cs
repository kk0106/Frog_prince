using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogSystem : MonoBehaviour
{

    [Header("ui組件")]
    public  Text  textLabel;



    [Header("文本文件")]
    public TextAsset textFile;
    public int index;
    public float TextSpeed;


    [Header("頭像")]
    public GameObject faceImage01;
    public GameObject face_namebox01;
    public GameObject faceImage02;
    public GameObject face_namebox02;

    [Header("選擇")]
    public Button btn1;
    public Button btn2;

    bool TextFinsh;
    bool cancelTyping;

    List<string> textList = new List<string>();
    // Start is called before the first frame update
    void Awake()
    {
        GetTextFronmFile(textFile);
        
        faceImage02.SetActive(false);
        face_namebox02.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);

        
    }

  

    private void OnEnable()
    {
        //textLabel.text = textList[index];
        //index++;
     

        TextFinsh = true;
        StartCoroutine(SetTextUI());
    }
    // Update is called once per frame
    void Update()
    {
        if (UserInput.instance.controls.playerControls.talk.WasPressedThisFrame()&&index==textList.Count)
        {
            gameObject.SetActive(false);
            index = 0;
            return;
        }


        //if (UserInput.instance.controls.playerControls.talk.WasPressedThisFrame()&& TextFinsh==true)
      //  {
            //textLabel.text = textList[index];
            // index++;
            //   StartCoroutine(SetTextUI());
            //}


            if (UserInput.instance.controls.playerControls.talk.WasPressedThisFrame())
            {
                if(TextFinsh && !cancelTyping)
                {
                     StartCoroutine(SetTextUI());
                }
                else if(!TextFinsh)
                {
                cancelTyping = !cancelTyping;
                }

            }


    }
    void GetTextFronmFile(TextAsset file)
    {
        textList.Clear();
        index = 0;

       var lineDate = file.text.Split('\n','\r');


        foreach (var line in lineDate)
        {
            textList.Add(line);
        }
        
    }

    IEnumerator SetTextUI()
    {
        TextFinsh=false;
        textLabel.text = "";

        switch (textList[index])
        {
            case "A":
                    faceImage01.SetActive(true);
                    face_namebox01.SetActive(true);
                    faceImage02.SetActive(false);
                    face_namebox02.SetActive(false);
                    index++;
                    break;

            case "B":
                    faceImage01.SetActive(false);
                    face_namebox01.SetActive(false);
                    faceImage02.SetActive(true);
                    face_namebox02.SetActive(true);
                    index++;
                    break;
                case "C":
                
                      btn1.gameObject.SetActive(true);
                      //btn2.gameObject.SetActive(true);
                
                
                break;
                case "D":
                       index++;
                       break;
                case "E":
                       index ++; break;
        }

        // for(int i=0;i<textList[index].Length;i++)
        //{
        //  textLabel.text += textList[index][i];
        //yield return new WaitForSeconds(TextSpeed);
        //}

        int letter = 0;
        while(!cancelTyping && letter < textList[index].Length - 1)
        {
            textLabel.text += textList[index][letter];
            letter++;
            yield return new WaitForSeconds(TextSpeed);
        }

        textLabel.text = textList[index];
        cancelTyping = false;
        TextFinsh=true;
        index++;
    }

    private void chose()
    {
        
    }
}

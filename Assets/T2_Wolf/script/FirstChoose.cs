using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstChoose : MonoBehaviour
{
    public static float FirstChooseInt;

    [Header("遊戲內建物")]
    public GameObject Easy;
    public GameObject Hard;
    public GameObject StartFirstPlan;
    // Start is called before the first frame update
    void Start()
    {
        Easy.SetActive(false);
        Hard.SetActive(false);
        FirstChooseInt = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(FirstChooseInt);

        if (FirstChooseInt == 1)
        {
            Easy.SetActive(true); 
        }

        if(FirstChooseInt == 2)
        {
            Hard.SetActive(true);
            StartFirstPlan.SetActive(false);
        }
    }
}

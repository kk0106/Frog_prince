using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class newUI : MonoBehaviour
{
    private GameObject MainMenuFirst;
    private GameObject SettingMenuFirst;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        EventSystem.current.SetSelectedGameObject(MainMenuFirst);
    }
}

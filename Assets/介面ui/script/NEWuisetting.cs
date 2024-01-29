using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class NEWuisetting : MonoBehaviour
{

    [SerializeField] public GameObject firstChoose;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        EventSystem.current.SetSelectedGameObject(firstChoose);
    }

    public void next()
    {
        SceneManager.LoadScene("StartAni");
    }
}

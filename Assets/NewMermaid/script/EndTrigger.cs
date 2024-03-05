using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    public GameObject godness;
    public GameObject img;
    public float time;
    private bool isEnd;
    // Start is called before the first frame update
    void Start()
    {
        isEnd = false;
        img.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isEnd)
        {
            time += Time.deltaTime;
        }

        if(time > 1.5)
        {
            img.SetActive(true);
        }

        if (time > 1.7 && UserInput.instance.controls.playerControls.KeepStory.WasPressedThisFrame())
        {
            SceneManager.LoadScene("T1_MermaidDie");
        }
        if (time > 2.5)
        {
            SceneManager.LoadScene("T1_MermaidDie");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player"&&godness.activeInHierarchy )
        {
            isEnd=true;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && godness.activeInHierarchy)
        {
            isEnd = true;
        }
    }
}

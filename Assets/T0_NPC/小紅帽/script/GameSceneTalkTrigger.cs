using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSceneTalkTrigger : MonoBehaviour
{
    public GameObject TalkBox_girl;
    public GameObject TalkBox_boy;
    public GameObject nose;
    // Start is called before the first frame update
    void Start()
    {
        TalkBox_boy.SetActive(false);
        TalkBox_girl.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(!nose.activeInHierarchy)
        {
            this.gameObject.SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {

        TalkBox_boy.SetActive(true);
        TalkBox_girl.SetActive(true);

        Invoke("outt", 2f);
    }
    private void outt()
    {

        TalkBox_boy.SetActive(false);
        TalkBox_girl.SetActive(false);
    }
    
}

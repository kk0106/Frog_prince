using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSceneTalkTrigger : MonoBehaviour
{
    public GameObject TalkBox_girl;
    public GameObject TalkBox_boy;
    public GameObject nose;
    
    AudioManager audioManager;
    private bool hasPlayedSFX = false;

    // Start is called before the first frame update
    private void awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    
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

        //if (TalkBox_girl.activeInHierarchy)
       // {
       //     player.MoveSpeed = 0f;
       //     player.JumpForce = 0f;
       // }
       // else
       // {
       //     player.MoveSpeed = 1.5f;  
       //     player.JumpForce = 3f;
       // }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !hasPlayedSFX)
        {
            AudioManager.Instance.PlaySFX(AudioManager.Instance.RedCry);
            hasPlayedSFX = true;
            TalkBox_boy.SetActive(true);
            TalkBox_girl.SetActive(true);

            Invoke("outt", 2f);
        }

    }
    private void outt()
    {

        TalkBox_boy.SetActive(false);
        TalkBox_girl.SetActive(false);
       // this.gameObject.SetActive(false);
    }
    
}

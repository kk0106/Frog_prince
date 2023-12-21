using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ANI_LONGNOSE : MonoBehaviour
{
    public GameObject a;
    public GameObject b;
    public GameObject papa;
    private Animator animator;
    AudioManager audioManager;
    private bool hasFunctionBeenCalled = false;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();  
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!a.activeInHierarchy)
        {
            animator.SetBool("break", true);
            papa.SetActive(true);
            b.SetActive(false);
             if (!hasFunctionBeenCalled)
            {
            AudioManager.Instance.PlaySFX(AudioManager.Instance.bigcrack);
            hasFunctionBeenCalled = true;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ANI_LONGNOSE : MonoBehaviour
{
    public GameObject a;
    public GameObject b;
    public GameObject papa;
    public float time;
    private Animator papaani;

    private Animator animator;
    AudioManager audioManager;
    private bool hasFunctionBeenCalled = false;
    // Start is called before the first frame update
    void Start()
    {
        papaani=papa.GetComponent<Animator>();
        animator = GetComponent<Animator>();  
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!a.activeInHierarchy)
        {
            animator.SetBool("break", true);
            
          //  b.SetActive(false);

            time-=Time.deltaTime;

             if (!hasFunctionBeenCalled)
            {
            AudioManager.Instance.PlaySFX(AudioManager.Instance.bigcrack);
            hasFunctionBeenCalled = true;
            }
        }

        if(time<2)
        {
            papa.SetActive(true);
          
        }

        if (time < 0)
        {

            papaani.SetBool("scared", true);
        }

        if (time < -1)
        {
            papaani.SetBool("run", true);
        }
    }
}

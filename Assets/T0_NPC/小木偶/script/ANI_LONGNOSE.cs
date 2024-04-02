using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ANI_LONGNOSE : MonoBehaviour
{
    public GameObject BoyShadow;
    private Animator BoyShadow_ani;

    public GameObject BoyDie;
    private Animator BoyDie_ani;

    public GameObject BoyDie_sh;
    private Animator BoyDieSh_ani;

    public float timeDie;

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

        BoyDie_ani = BoyDie.gameObject.GetComponent<Animator>();
        BoyShadow_ani = BoyShadow.gameObject.GetComponent<Animator>();
        BoyDieSh_ani = BoyDie_sh.gameObject.GetComponent<Animator>();


        papaani =papa.GetComponent<Animator>();
        animator = GetComponent<Animator>();  
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
       if(timeDie > 0.55)
        {
            BoyDie_ani.SetBool("fall", true);
            BoyDieSh_ani.SetBool("fall", true);
        }

        if(!a.activeInHierarchy)
        {
            timeDie += Time.deltaTime;

            animator.SetBool("break", true);

            BoyShadow_ani.SetBool("break", true);

           

            //  b.SetActive(false);

            time -=Time.deltaTime;

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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardStartTrigger : MonoBehaviour
{
    public GameObject cam;
    public float time;
    public GameObject CindyTalkStart;

    public GameObject trigger;
    // Start is called before the first frame update
    void Start()
    {
        CindyTalkStart.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (CardStartTriggerValue.start == 1)
        {
            time-=Time.deltaTime;
        }

        if (time <2.5)
        {
            cam.SetActive(true);

            CindyTalkStart.SetActive(true );
        }
        if(time < 0)
        {
            cam.SetActive(false);

            CindyTalkStart.SetActive(false );

            CardStartTriggerValue.start = 0;

            time = 4;


            trigger.SetActive(false);
        }
    }
}

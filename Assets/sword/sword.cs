using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword : MonoBehaviour
{
    public GameObject swordd;
    public GameObject carrdio;


    [Header("TalkChange")]
    private SpriteRenderer spr_talk;
    public Sprite[] img;
    public GameObject talk_person;
    public float time;
    public int a;

    // Start is called before the first frame update
    void Start()
    {
        swordd.SetActive(false);
        carrdio.SetActive(false);

        spr_talk=talk_person.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (a==1)
        {
            spr_talk.sprite = img[1];
           time-=Time.deltaTime;
        }
        if (time < 0)
        {
            a = 2;
        }

        if (a==2)
        {
            spr_talk.sprite = img[2];
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            swordd.SetActive(true);
            carrdio.SetActive(true);

            a = 1;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class t0tot1Talk : MonoBehaviour
{

    public GameObject p;
    public GameObject f;
    public float time;

    private Image sprP;
    private Image sprF;

    public Sprite[] imgP;
    public Sprite[] imgF;

    // Start is called before the first frame update
    void Start()
    {
        sprF = f.GetComponent<Image>();
        sprP = p.GetComponent<Image>();

        f.SetActive(false);
        p.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.activeInHierarchy)
        {
            time += Time.deltaTime;

        }


        if (time > 1)
        {
            f.SetActive(true);
        }

        if (time > 2)
        {
            p.SetActive(true);
        }

        if(time>3.5)
        {
            sprF.sprite = imgF[1];
        }
        if (time > 6)
        {
            sprP.sprite = imgP[1];
        }
        if (time > 7.5)
        {
            sprP.sprite = imgP[2];
        }
        if (time > 9)
        {
            sprF.sprite = imgF[2];
        }
        if (time > 10.5)
        {
            sprP.sprite = imgP[3];
        }
        if (time > 12)
        {
            sprF.sprite = imgF[3];
        }
        if (time > 13.5)
        {
            sprP.sprite = imgP[4];
        }
    }
}

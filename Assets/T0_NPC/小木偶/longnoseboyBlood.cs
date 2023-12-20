using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class longnoseboyBlood : MonoBehaviour
{
    private BreakableObject breakableObject;
    private SpriteRenderer spr;
    public Sprite[] img;
    // Start is called before the first frame update
    void Start()
    {
        breakableObject = GetComponent<BreakableObject>();
        spr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(BreakableObject.a==15)  
        
        {
            spr.sprite = img[0];
        }
        if (BreakableObject.a==10)

        {
            spr.sprite = img[1];
        }
        if (BreakableObject.a==5)

        {
            spr.sprite = img[2];
        }
        if (BreakableObject.a==0)

        {
            spr.sprite = img[3];
            this.gameObject.SetActive(false);
        }

    }
}

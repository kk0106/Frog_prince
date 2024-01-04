using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spriderHp : MonoBehaviour
{
    public GameObject sprider;
    private SpriteRenderer spr;
    public Sprite[] img;

    public  int hp;
    // Start is called before the first frame update
    void Start()
    {
        spr = sprider.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hp == 3)
        {
            spr.sprite = img[0];
        }

        if (hp == 2)
        {
            spr.sprite = img[1];
        }


        if (hp == 1)
        {
            spr.sprite = img[2];
        }

        if (hp == 0)
        {
          this.gameObject.SetActive(false);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "NewApple")
        {
            hp -= 1;

            Destroy(other.gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 魔鏡hp : MonoBehaviour
{
    public float time;
    public GameObject boom;
    public GameObject poison;
    public int hp;
    public GameObject BOSS;
    private SpriteRenderer spr;
    public Sprite[] img;
    // Start is called before the first frame update
    void Start()
    {
        BOSS.SetActive(true);
        hp = 3;

        boom.SetActive(false);

      spr = BOSS.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hp < 0)
        {
            time-=Time.deltaTime;
        }

        if(time<1.5)
        {
            boom.SetActive(true);
        }

        if(time< 0.6)
        {
            BOSS.gameObject.SetActive(false);

            poison.SetActive(false);
        }

        if (hp == 3)
        {
            spr.sprite = img[0];
        }
        if(hp == 2)
        {
            spr.sprite = img[1];
        }
        if (hp == 1)
        {
            spr.sprite = img[2];
        }

    }


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "NewApple"&&WichTurnFace.CanAttack==1)
        {
            hp -= 1;

            Destroy(other.gameObject);
        }
    }
}

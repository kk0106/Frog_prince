using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHp : MonoBehaviour
{
    [Header("Start")]
    public GameObject boss;
    public GameObject bloom;
    public float time;

    [Header("hp")]
    public GameObject hp;
    public int hpint;
    private SpriteRenderer HpSpr;
    public Sprite[] Hpimg;
    // Start is called before the first frame update
    void Start()
    {
        bloom.SetActive(false);
        boss.SetActive(false);
        hp.SetActive(false);

        hpint = 6;

        HpSpr =hp.GetComponent<SpriteRenderer>();
      
    }

    // Update is called once per frame
    void Update()
    {
        //�_�l�]�w(�t�ʵe)
        time += Time.deltaTime;

        if (time > 1)
        {
            bloom.SetActive (true);
        }

        if (time > 1.5)
        {
            boss.SetActive(true);
        }
        if (time > 2)
        {
            hp.SetActive(true);
        }

        //��q�]�w
        if (hpint == 6)
        {
            HpSpr.sprite = Hpimg[0];
        }
        if (hpint == 5)
        {
            HpSpr.sprite = Hpimg[1];
        }
        if (hpint == 4)
        {
            HpSpr.sprite = Hpimg[2];
        }
        if (hpint == 3)
        {
            HpSpr.sprite = Hpimg[3];
        }
        if (hpint == 2)
        {
            HpSpr.sprite = Hpimg[4];
        }
        if (hpint == 1)
        {
            HpSpr.sprite = Hpimg[5];
        }
        if (hpint == 0)
        {
            HpSpr.sprite = Hpimg[6];
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ax")
        {
            hpint -= 1;
        }
    }
}

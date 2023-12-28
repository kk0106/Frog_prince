using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{

    public SpriteRenderer spr;
    public Sprite[] img;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (ShootGun.GetApple == 1)
        {
            Debug.Log(ShootGun.GetApple);
        }

        if (ShootGun.GetApple == 2)
        {
            Debug.Log(ShootGun.GetApple);
        }

        if (ShootGun.GetApple == 3)
        {
            Debug.Log(ShootGun.GetApple);
        }
    }
}

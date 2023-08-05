using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopText : MonoBehaviour
{
    public GameObject shop;
    public GameObject arleebaba;
    public GameObject Post1;
    public GameObject Post2;
    // Start is called before the first frame update
    void Start()
    {
        shop.SetActive(false);
        arleebaba.SetActive(false);
        Post1.SetActive(false);
        Post2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        other.gameObject.tag = "Player";
        shop.SetActive(true);
        arleebaba.SetActive(true);
        Post1.SetActive(true);  
        Post2.SetActive(true);
    }
    private void OnCollisionExit(Collision other)
    {
        other.gameObject.tag = "Player";
        shop.SetActive(false);
        arleebaba.SetActive(false);
        Post1.SetActive(false); 
        Post2.SetActive(false);
    }
}

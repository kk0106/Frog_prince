using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MermaidHp : MonoBehaviour
{
    public int hp;
    public GameObject hp6;
    public GameObject hp5;
    public GameObject hp4;
    public GameObject hp3;
    public GameObject hp2;
    public GameObject hp1;
   

    public GameObject bloom;

    // Start is called before the first frame update
    void Start()
    {
      
        hp1.SetActive(false);
        hp2.SetActive(false);
        hp3.SetActive(false);
        hp4.SetActive(false);
        hp5.SetActive(false);
        bloom.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (hp == 6&&attack1.SetAni==0)
        {
            hp6.SetActive(true);
        }

        if (hp == 5) 
        {
            hp5.SetActive(true);
            hp6.SetActive(false);
        }
        if (hp == 4)
        {
            hp6.SetActive(false);
            hp4.SetActive(true);
            hp5.SetActive(false);
        }
        if (hp == 3)
        {
            hp6.SetActive(false);
            hp4.SetActive(false);
            hp5.SetActive(false);
            hp3.SetActive(true);
        }
        if (hp == 2)
        {
            hp6.SetActive(false);
            hp4.SetActive(false);
            hp5.SetActive(false);
            hp3.SetActive(false);
            hp2.SetActive(true);
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "pp1")
        {
            bloom.SetActive(true);
            hp -= 1;
        
           
        }
    }
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "pp1")
        {
            bloom.SetActive(false);
            Destroy(other.gameObject);
        }
    }

}

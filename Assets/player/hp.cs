using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hp : MonoBehaviour
{
    [Header("blood")]
    public GameObject blood;
    public GameObject blood1;
    public GameObject blood2;
    public int HP;
    public int a;


    [Header("die")]
    public GameObject die;
    public GameObject die1;
    public GameObject die2;

    [Header("POS")]
    public Vector3 pos;
    public Vector3 pos2;
    public Vector3 pos3;
    public Vector3 pos4;
    public Vector3 pos5;
    public Vector3 pos6;

   
    public GameObject GGpanel;
    public GameObject loading;
    // Start is called before the first frame update
    void Start()
    {
        GGpanel.SetActive(false);
        blood.SetActive(true);
        blood1 .SetActive(true);
        blood2 .SetActive(true);
        die.SetActive(false);
        die1.SetActive(false);
        die2.SetActive(false);
        HP = 3;
        loading.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (a > 0)
        {
            loading.SetActive(true);
            Invoke("GoPos", 2f);
        }
        if (a > 0&&HP==0)
        {
            loading.SetActive(false);
           //nvoke("GoPos", 3f);
        }

        if (HP== 3)
        {
            blood.SetActive(true);
            blood1.SetActive(true);
            blood2.SetActive(true);
            die.SetActive(false);
            die1.SetActive(false);
            die2.SetActive(false);
            GGpanel .SetActive(false);  
        }

        if(HP== 2)
        {
            blood.SetActive(false);
            blood1.SetActive(true);
            blood2.SetActive(true);
            die.SetActive(true);
            die1.SetActive(false);
            die2.SetActive(false);
            GGpanel.SetActive (false);
        }

        if(HP== 1)
        {
            blood.SetActive(false);
            blood1.SetActive(false);
            blood2.SetActive(true);
            die.SetActive(true);
            die1.SetActive(true);
            die2.SetActive(false);
            GGpanel .SetActive(false);
        }

        if (HP == 0)
        {
            GGpanel.SetActive(true);

            blood.SetActive(false);
            blood1.SetActive(false);
            blood2.SetActive(false);
            die.SetActive(true);
            die1.SetActive(true);
            die2.SetActive(true);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "apple")
        {
            HP -= 1;

           // this.gameObject.transform.position = pos;
            a = 1;
            
        }
        if (other.gameObject.tag == "hole")
        {
            HP -= 1;
            a = 2;
           // this.gameObject.transform.position = pos2;
        }
        if (other.gameObject.tag == "poison")
        {
            HP -= 1;
            a = 3;
           // this.gameObject.transform.position = pos3;
        }
        if (other.gameObject.tag == "egg")
        {
            HP -= 1;
          //  a = 4;
            //this.gameObject.transform.position = pos4;
        }
        if (other.gameObject.tag == "Swamp")
        {
            HP -= 1;
            a = 5;
            //this.gameObject.transform.position = pos4;
        }

        if(other.gameObject.tag == "Trident")
        {
            HP -= 1;
            a = 6;
        }
    }


   private void GoPos()
    {
        if(a==1)
        {
            this.gameObject.transform.position = pos;
            a =0;
            loading.SetActive(false);
        }

        if (a == 2)
        {
            this.gameObject.transform.position = pos2;
            a = 0;
            loading.SetActive(false);
        }

        if (a == 3)
        {
            this.gameObject.transform.position = pos3;
            a = 0;
            loading.SetActive(false);
        }

        if (a == 4)
        {
            this.gameObject.transform.position = pos4;
            a = 0;
            loading.SetActive(false);
        }

        if (a == 5)
        {
            this.gameObject.transform.position = pos5;
            a = 0;
            loading.SetActive(false);
        }

        if(a == 6)
        {
            this.gameObject.transform.position = pos6;
            a = 0;
            loading.SetActive(false);
        }
    }
}

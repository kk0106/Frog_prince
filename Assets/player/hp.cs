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

    public static int BeeDes;

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
    public Vector3 pos8;
    public Vector3 pos9;
    public Vector3 pos10;
    public Vector3 pos11;
    public Vector3 pos12;
    public Vector3 pos13;
    public Vector3 pos14;

    //public Vector3 WolfPos;
   // public GameObject wolf;
    //public float wolfvalue;

    public GameObject GGpanel;
    public GameObject loading;
    // Start is called before the first frame update
    void Start()
    {
        GGpanel.SetActive(false);
       // blood.SetActive(true);
     //   blood1 .SetActive(true);
       // blood2 .SetActive(true);
        die.SetActive(false);
        die1.SetActive(false);
        die2.SetActive(false);
        HP = 3;
        loading.SetActive(false);

        BeeDes = 0;
    }

    // Update is called once per frame
    void Update()
    {
      //  WolfPos=wolf.transform.position;

      //  pos11 = new Vector3(WolfPos.x + wolfvalue, 0.24f, -45.43f);

        if (a > 0)
        {
            loading.SetActive(true);
            Invoke("GoPos", 0.3f);
            
        }
        if (a > 0&&HP==0)
        {
            loading.SetActive(false);
           //nvoke("GoPos", 3f);
        }

        if (HP== 3)
        {
       //     blood.SetActive(true);
        //    blood1.SetActive(true);
         //   blood2.SetActive(true);
            die.SetActive(false);
            die1.SetActive(false);
            die2.SetActive(false);
            GGpanel .SetActive(false);  
        }

        if(HP== 2)
        {
           // blood.SetActive(false);
           // blood1.SetActive(true);
           // blood2.SetActive(true);
          //  die.SetActive(true);
            die1.SetActive(false);
            die2.SetActive(false);
            GGpanel.SetActive (false);
        }

        if(HP== 1)
        {
          // blood.SetActive(false);
           // blood1.SetActive(false);
          //  blood2.SetActive(true);
          //  die.SetActive(true);
          //  die1.SetActive(true);
            die2.SetActive(false);
            GGpanel .SetActive(false);
        }

        if (HP == 0)
        {
           // GGpanel.SetActive(true);

            blood.SetActive(false);
            blood1.SetActive(false);
            blood2.SetActive(false);
          //  die.SetActive(true);
          //  die1.SetActive(true);
          //  die2.SetActive(true);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "apple"|| other.gameObject.tag == "BambooShoots" || other.gameObject.tag == "card")
        {
            HP -= 1;

           // this.gameObject.transform.position = pos;
            a = 1;
            
        }
       
        if (other.gameObject.tag == "poison"|| other.gameObject.tag == "apple2")
        {
            HP -= 1;
            a = 3;
           // this.gameObject.transform.position = pos3;
        }
       
        if (other.gameObject.tag == "Swamp")
        {
            HP -= 1;
            a = 5;
            //this.gameObject.transform.position = pos4;
        }

        
        if (other.gameObject.tag == "spring")
        {
            HP -= 1;
            a = 7;
        }
        if (other.gameObject.tag == "hand")
        {
            HP -= 1;
           a = 8;
        }
        if (other.gameObject.tag == "aa")
        {
            HP -= 1;
            a = 8;
        }
      
        if (other.gameObject.tag == "ball"|| other.gameObject.tag == "goose")
        {
            HP -= 1;
            a = 10;
            BeeDes = 1;
        }

        if (other.gameObject.tag == "wolf" )
        {
            HP -= 1;
            a = 11;
        }
        if (other.gameObject.tag == "Monster")
        {
            HP -= 1;
            a = 12;
        }
        if (other.gameObject.tag == "Monster2")
        {
            HP -= 1;
            a = 13;
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ball" || other.gameObject.tag == "goose")
        {
            HP -= 1;
            a = 10;
        }

        if (other.gameObject.tag == "wolf")
        {
            HP -= 1;
            a = 11;
        }
        if (other.gameObject.tag == "Monster")
        {
            HP -= 1;
            a = 12;
        }
        if (other.gameObject.tag == "Monster2")
        {
            HP -= 1;
            a = 13;
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

            if (BossCamTrigger.a == 1)
            {
                this.gameObject.transform.position = pos14;
            }
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
        if (a == 8)
        {
            this.gameObject.transform.position = pos8;
            a = 0;
            loading.SetActive(false);
        }
        if (a == 9)
        {
            this.gameObject.transform.position = pos9;
            a = 0;
            loading.SetActive(false);
        }

        if (a == 10)
        {
            this.gameObject.transform.position = pos10;
            a = 0;
            loading.SetActive(false);

            BeeDes = 0;
        }

        if (a == 11)
        {
            this.gameObject.transform.position = pos11;
            a = 0;
            loading.SetActive(false);
        }
        if (a == 12)
        {
            this.gameObject.transform.position = pos12;
            a = 0;
            loading.SetActive(false);
        }
        if (a == 13)
        {
            this.gameObject.transform.position = pos13;
            a = 0;
            loading.SetActive(false);
        }
    }
}

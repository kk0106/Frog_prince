using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hp : MonoBehaviour
{
    public GameObject blood;
    public GameObject blood1;
    public GameObject blood2;

    public GameObject die;
    public GameObject die1;
    public GameObject die2;

    public Vector3 pos;
    public Vector3 pos2;

    public int HP;

    public GameObject GGpanel;
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
    }

    // Update is called once per frame
    void Update()
    {
        if(HP== 3)
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

            this.gameObject.transform.position = pos;
            
            
        }
        if (other.gameObject.tag == "hole")
        {
            HP -= 1;

            this.gameObject.transform.position = pos2;
        }
    }
}

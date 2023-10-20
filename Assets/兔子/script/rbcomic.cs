using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class rbcomic : MonoBehaviour
{
    public GameObject player;
    //public GameObject comicPanel;
    public GameObject trigger;

    [Header("timer")]
    [SerializeField] public float time_f=0;
    [SerializeField] public int time_i=0;

    [Header("comic")]
    [SerializeField] public static int A=0;
    [SerializeField] public GameObject com1;
    [SerializeField] public GameObject com2;
    [SerializeField] public GameObject com3;
    [SerializeField] public GameObject com4;
    [SerializeField] public GameObject com5;

    // Start is called before the first frame update
    void Start()
    {
       // comicPanel.SetActive(false);
        com1.SetActive(false);
        com2.SetActive(false);
        com3.SetActive(false);
        com4.SetActive(false);  
        com5.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       

        if (A == 1 )
        {
            time_f += Time.deltaTime;
            time_i = (int)time_f;
        }
        
        
                if (time_i == 0)
                {
                    com1.SetActive (false);
                    com2.SetActive (false); 
                    com3.SetActive (false);
                    com4.SetActive (false);
                    com5.SetActive (false);
               
                }
                
                if (time_i == 1)
                {
                    com1.SetActive (true);
                    com2.SetActive (false); 
                    com3.SetActive (false);
                    com4.SetActive (false);
                    com5.SetActive (false);
                }

                if (time_i == 2)
                {
                    com1.SetActive(true);
                    com2.SetActive(true);
                    com3.SetActive(false);
                    com4.SetActive(false);
                    com5.SetActive(false);
                }

                if (time_i == 3)
                {
                    com1.SetActive(true);
                    com2.SetActive(true);
                    com3.SetActive(true);
                    com4.SetActive(false);
                    com5.SetActive(false);
                }

                if (time_i == 5)
                {
                    com1.SetActive(true);
                    com2.SetActive(true);
                    com3.SetActive(true);
                    com4.SetActive(true);
                    com5.SetActive(false);
                }

                if (time_i == 6)
                {
                    com1.SetActive(true);
                    com2.SetActive(true);
                    com3.SetActive(true);
                    com4.SetActive(true);
                    com5.SetActive(true);
                }

                if (time_i == 8)
                {
                    com1.SetActive(false);
                    com2.SetActive(false);
                    com3.SetActive(false);
                    com4.SetActive(false);
                    com5.SetActive(false);
                    trigger.SetActive(false);
                   A = 0;
                }

       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            A = 1;
            //  comicPanel.SetActive(true);
           
        }
    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour
{
    public GameObject cammushroom;
    public Vector3 playerPos;
    public GameObject player;
    public float x;
    public float z;
    public int a;
    // Start is called before the first frame update
    void Start()
    {
        cammushroom.SetActive(false);
        a = 0;
    }

    // Update is called once per frame
    void Update()
    {
       if(a==1)
        {
            cammushroom.SetActive(true);

            x = playerPos.x; z = playerPos.z;

            playerPos = player.transform.position;
            this.gameObject.transform.position = new(x, 3, z);
        }
       if(a==2)
        {
            cammushroom.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            a = 1;
        }


    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            a = 1;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            a = 2;
        }
    }
}

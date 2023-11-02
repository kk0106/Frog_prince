using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swamp_cam : MonoBehaviour
{
    public Vector3 playerPos;
    public GameObject player;
    public float x;


    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {


        x = playerPos.x;
        playerPos = player.transform.position;
        this.gameObject.transform.position = new(x, 0.22f, -45f);
     //   this.gameObject.transform.rotation = Quaternion.Euler(12.26f, 0.06f, 0);


    }

}

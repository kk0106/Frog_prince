using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundPointMove : MonoBehaviour
{
    public GameObject player;
    public Vector3 pos;
    public float a;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        pos = player.transform.position;

        this.gameObject.transform.position = new Vector3(pos.x, pos.y -a, pos.z) ;
    }
}

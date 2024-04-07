using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class T1CamFollow : MonoBehaviour
{
    public GameObject player;
    public Vector3 player_pos;
    private float x;
    private float z;

    // Start is called before the first frame update
 

    // Update is called once per frame
    void Update()
    {
       player_pos = new Vector3(player.transform.position.x, 0, player.transform.position.z);
    

        this.gameObject.transform.position =player_pos;
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecam : MonoBehaviour
{
    public GameObject player_a;
    private Vector3 player_pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player_pos = player_a.transform.position;

        this.transform.position = new Vector3(7.7f,8.28f,player_pos.z);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T2PlayerCam : MonoBehaviour
{

    public GameObject player;
    public Vector3 PlayerPos;
    public float CamHight;
    public float CamXSetting;

    // Start is called before the first frame update
    void Start()
    {
      // PlayerPos=player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        PlayerPos = player.transform.position;
        this.gameObject.transform.position = new Vector3(PlayerPos.x+CamXSetting,CamHight,PlayerPos.z);
    }
}

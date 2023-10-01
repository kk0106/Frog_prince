using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arleebaba_ui : MonoBehaviour
{
    public Transform lookAt;
    public Vector3 offest;

    private Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam=Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
       Vector3 pos=cam.WorldToScreenPoint(lookAt.position + offest);

        if(transform.position != pos)transform.position = pos;
    }
}

using Mono.Cecil;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundParallax : MonoBehaviour
{
    public Transform[] background;
    public float parallaxScale;
    public float parallaxReductionFactor;
    public float smoothing;

    private Transform cam;
    private Vector3 previousCamPos;
    // Start is called before the first frame update


    private void Awake()
    {
        cam = Camera.main.transform;
    }

    void Start()
    {
        previousCamPos = cam.position;
    }

    // Update is called once per frame
    void Update()
    {
       float parallax=(previousCamPos.x-cam.position.x)*parallaxScale;


        for(int i = 0; i < background.Length; i++)
        {
            float backgroundTargetPosX = background[i].position.x + parallax * (i * parallaxReductionFactor + 1);

            Vector3 backgroundTargetPos=new Vector3(backgroundTargetPosX, background[i].position.y, background[i].position.z);

            background[i].position = Vector3.Lerp(background[i].position,backgroundTargetPos,smoothing*Time.deltaTime);

            previousCamPos = cam.position;
        }
    }
}

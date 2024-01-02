using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToonShader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float3 _WorldSpaceLightPos0;

    void GetMainLight_float(out float3 lightDir)
    {
        lightDir = _WorldSpaceLightPos0;
    }
}

float3 _WorldSpaceLightPos0; 

void GetMainLight_float (out float3 lightDir) { 
    lightDir = _WorldSpaceLightPos0; 
}
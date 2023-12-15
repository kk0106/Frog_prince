Shader "MayoHa/ToonIce" {

	Properties{
		_Color("Main Color", Color) = (0.49,0.94,0.64,1)// top gradient, light green
		_TColor("Top Color", Color) = (0.49,0.94,0.64,1)// top gradient, light green
		_BottomColor("Bottom Color", Color) = (0.23,0,0.95,1)// bottom gradient, blue
		_Ramp("Toon Ramp (RGB)", 2D) = "gray" {}
		[Header(specular)]
		[Toggle]_Specular("Enable Specular",Float) = 0
		[HDR]_SpecularColor("Specular Color",Color) = (1,1,1,1)
		_SpecularOffSet("Specular OffSet",Range(0,1)) = 0.9

		[Header(Rim_Fresnel)]
		_RimBrightness("Rim Brightness", Range(3,4)) = 3.2 // ice rim brightness
		_Offset("Gradient Offset", Range(-4,4)) = 3.2 // ice rim brightness
		_InnerRimOffSet("Inner Rim OffSet",Range(-3,3)) = 1.5
	}

		SubShader{
		Tags{ "RenderType" = "Opaque" }

		LOD 200
		CGPROGRAM
#pragma surface surf ToonRamp

		sampler2D _Ramp;

#pragma lighting ToonRamp 
	inline half4 LightingToonRamp(SurfaceOutput s, half3 lightDir, half atten)
	{
#ifndef USING_DIRECTIONAL_LIGHT
		lightDir = normalize(lightDir);
#endif

		half d = dot(s.Normal, lightDir) * 0.5 + 0.5;
		half3 ramp = tex2D(_Ramp, float2(d,d)).rgb;

		half4 c;
		c.rgb = s.Albedo * _LightColor0.rgb * ramp * (atten * 2);
		c.a = s.Alpha;
		return c;
	}

	float _Offset;
	float _SpecularOffSet;
	float4 _Color;
	float4 _TColor;
	float4 _SpecularColor;
	float4 _BottomColor;// bottom gradient color
	float _RimBrightness;// ice rim brightness
	float _Specular;
	float _InnerRimOffSet;


	struct Input {
		float3 viewDir; // view direction
		float3 worldPos; // world position
		float3 lightDir;
	};

	void surf(Input IN, inout SurfaceOutput o) {

		//localPos
		float3 localPos = (IN.worldPos - mul(unity_ObjectToWorld, float4(0, 0, 0, 1)).xyz);// local position of the object, with an offset, clamped to make sure it doesn't go into negative
		float3 AdjustLocalPos = saturate(float3(IN.worldPos.x,IN.worldPos.y,IN.worldPos.z)).xyz + 0.4;

		//Rim
		float softRim = 1.0 - saturate(dot(normalize(IN.viewDir), o.Normal));// calculate a soft fresnel based on the view direction and the normals of the object
		float hardRim = round(softRim); // round it up for a harder edge

		//Specular
		float h = normalize(IN.viewDir + IN.lightDir);
		float HdotN = saturate(dot(h,o.Normal));
		half3 specularColor = _SpecularColor.rgb * (HdotN * softRim > _SpecularOffSet ? 1 : 0);

		//Emission
		o.Emission = _Color * lerp(hardRim, softRim, saturate(AdjustLocalPos.x + AdjustLocalPos.y)) * lerp(0,_RimBrightness,AdjustLocalPos.y);	 // lerp the emission from the hard rim to the softer one, based on the position

		float innerRim = _InnerRimOffSet + saturate(dot(normalize(IN.viewDir), o.Normal));
		//Albedo
		o.Albedo = _Color * pow(innerRim, 0.7) * lerp(_BottomColor, _TColor, saturate(localPos.y + _Offset)) + specularColor * _Specular;

		//Alpha
		o.Alpha = 1;

	}
	ENDCG

		}

			Fallback "Diffuse"
}


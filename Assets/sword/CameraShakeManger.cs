using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraShakeManger : MonoBehaviour
{
    // Start is called before the first frame update
    public static CameraShakeManger Instance;

    [SerializeField] private float globalShakeForce = 1f;
    [SerializeField] private CinemachineImpulseListener impulseListener;

    private CinemachineImpulseDefinition impulseDefinition;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
       
    }


    public void Update()
    {
       
    }

    public void cameraShake(CinemachineImpulseSource impulseSource)
    {
        impulseSource.GenerateImpulseWithForce(globalShakeForce);
    }

    public void ScreenShakeFromProfile(ScreeenShakeProfile profile,CinemachineImpulseSource impulseSource)
    {
        SetupScreenShakeSettinngs(profile, impulseSource);

        impulseSource.GenerateImpulseWithForce(profile.impactForce);
    }

    private void SetupScreenShakeSettinngs(ScreeenShakeProfile profile,CinemachineImpulseSource impulseSource)
    {
        impulseDefinition = impulseSource.m_ImpulseDefinition;

        impulseDefinition.m_ImpulseDuration = profile.impactTime;
        impulseSource.m_DefaultVelocity=profile.defaultVelocity;
        impulseDefinition.m_CustomImpulseShape = profile.impulseCurve;

        impulseListener.m_ReactionSettings.m_AmplitudeGain = profile.listenerAmplitude;
        impulseListener.m_ReactionSettings.m_FrequencyGain = profile.listenerFrequency;
        impulseListener.m_ReactionSettings.m_Duration= profile.listenerDuration;

       
    }

    
}

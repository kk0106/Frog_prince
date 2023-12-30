using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{
    public GameObject SWORD;
    private CinemachineImpulseSource impulseSource;
    [SerializeField] private ScreeenShakeProfile profile;
    // Start is called before the first frame update
    void Start()
    {
        impulseSource = GetComponent<CinemachineImpulseSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (SWORD.activeInHierarchy)
        {
            CameraShakeManger.Instance.ScreenShakeFromProfile(profile, impulseSource);
        }
    }
}

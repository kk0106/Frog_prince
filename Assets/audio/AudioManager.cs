using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance;

    [Header("------- Audio Source -------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("------- Audio Clip -------")]
    public AudioClip CinHap;
    public AudioClip CinMad;
    public AudioClip PapaScar;
    public AudioClip RedCry;
    public AudioClip witch;

    public static AudioManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<AudioManager>();

                if (instance == null)
                {
                    GameObject obj = new GameObject();
                    obj.name = "AudioManager";
                    instance = obj.AddComponent<AudioManager>();
                }
            }

            return instance;
        }
    }

    private void Start()
    {
        musicSource.clip = witch;
        musicSource.Play();
    }
    
    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}


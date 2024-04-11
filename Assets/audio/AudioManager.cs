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
    public AudioClip background;
    public AudioClip smallcrack;
    public AudioClip bigcrack;
    public AudioClip jump;
    public AudioClip lick;
    public AudioClip spit;
    public AudioClip glass1;
    public AudioClip glass2;
    public AudioClip glass3;
    public AudioClip smash;
    public AudioClip raccoonCry;
    public AudioClip woodlaugh;
    public AudioClip turtleCry;

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
        musicSource.clip = background;
        musicSource.Play();
    }
    
    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}


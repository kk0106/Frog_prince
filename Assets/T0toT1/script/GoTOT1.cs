using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoTOT1 : MonoBehaviour
{
    public GameObject comic;
    // Start is called before the first frame update
    void Start()
    {
        comic.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void goo()
    {
        comic.SetActive(true);
    }
}

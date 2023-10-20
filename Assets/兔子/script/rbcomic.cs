using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rbcomic : MonoBehaviour
{
    public GameObject player;
    public GameObject comicPanel;

    [Header("comic")]
    [SerializeField] public GameObject com1;
    [SerializeField] public GameObject com2;
    [SerializeField] public GameObject com3;
    [SerializeField] public GameObject com4;
    [SerializeField] public GameObject com5;

    // Start is called before the first frame update
    void Start()
    {
        comicPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            comicPanel.SetActive(true);
        }
    }
}

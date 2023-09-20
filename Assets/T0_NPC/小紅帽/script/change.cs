using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change : MonoBehaviour
{
    private Animator _animator;
    public GameObject nose;
    public GameObject TalkTriggerBox;
   
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();

       TalkTriggerBox.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    { 
        if (!nose.activeInHierarchy)
        {
            _animator.SetBool("happy", true);

            TalkTriggerBox.SetActive(true);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        _animator.SetBool("cry", true);

        
    }

    
}

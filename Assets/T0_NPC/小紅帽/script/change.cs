using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change : MonoBehaviour
{
    private Animator _animator;
    public GameObject a;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!a.activeInHierarchy)
        {
            _animator.SetBool("happy",true);         }
    }
    private void OnTriggerEnter(Collider other)
    {
        _animator.SetBool("cry", true);
    }
    
}

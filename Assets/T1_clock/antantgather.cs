using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class antantgather : MonoBehaviour
{
private Animator _animator; 
public GameObject a;
public GameObject b;
public GameObject c;
// Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(a.activeInHierarchy)
        {
            _animator.SetBool("next2", true);
            b.SetActive(true);
            c.SetActive(false);
            
        }
    }
}

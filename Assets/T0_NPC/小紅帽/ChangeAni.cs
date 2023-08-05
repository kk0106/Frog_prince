using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAni : MonoBehaviour
{
    private Animator ani;

    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
        ani.SetBool("jump", false);

        StartCoroutine("dosomething");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator dosomething()
    {
        while (true)
        {
            yield return new WaitForSeconds(10);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activeA : MonoBehaviour
{
public GameObject A;
public GameObject mermaid;
private Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
         _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (A.activeInHierarchy)
        {
            
            _animator.SetBool("next2", true);
            StartCoroutine(killmermaidAfterDelay());
        }
    }
     IEnumerator killmermaidAfterDelay()
    {
        yield return new WaitForSeconds(2f);

        mermaid.SetActive(false);

          // You can't use the `foreach` loop here; you should use a `for` loop.
        // And you should set the `trigger` variable of each MovingPlatform.
    }
}

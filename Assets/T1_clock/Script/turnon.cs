using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnon : MonoBehaviour
{
    public GameObject A;
    public GameObject clockwork;
    private Animator _animator;
    public GameObject key;
    // Start is called before the first frame update
    void Start()
    {
        // key.SetActive(true);
        _animator = GetComponent<Animator>();
        // You should use FindObjectsOfType to find all instances of the MovingPlatform script.
        // You need to store these in an array to loop through them later.
        

        // Now, you have the objects with the MovingPlatform script in the `objectsWithMyScript` array.
    }

    // Update is called once per frame
    void Update()
    {
        if (!A.activeInHierarchy)
        {

            key.SetActive(false);
            clockwork.SetActive(true);
            _animator.SetBool("next", true);

            // You can't use the `foreach` loop here; you should use a `for` loop.
            // And you should set the `trigger` variable of each MovingPlatform.
            MovingPlatform[] objectsWithMyScript = FindObjectsOfType<MovingPlatform>();
            for (int i = 0; i < objectsWithMyScript.Length; i++)
            {
                objectsWithMyScript[i].Trigger = true;
            }

        
        }
    }
}

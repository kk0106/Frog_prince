using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change2 : MonoBehaviour
{
    public float speed = 5.0f; // Speed at which the character moves
    private Animator _animator;

    public GameObject nose;
    public GameObject trigger;
    public float time;

   // public GameObject shadow;
   // private Animator ani;
    // Start is called before the first frame update
    void Start()
    {

        trigger.SetActive(false);   
        _animator = GetComponent<Animator>();
     //   ani = shadow.gameObject.GetComponent<Animator>();
    }

    private void Update()
    {
        if (!nose.activeInHierarchy)
        {
            _animator.SetBool("next2", true);

            time += Time.deltaTime;
        }

        if (time > 3)
        {
            trigger.SetActive(true);
        }
        if(time >3.1)
        {
            _animator.SetBool("talk", true);
        }

    }

    // Update is called once per frame
    

    public void UpdateAnimation31()
    {
       // _animator.SetBool("talk", true);
        //   ani.SetBool("next2", true);
    }

    public void UpdateAnimation3()
{
    _animator.SetBool("next3", true);
}
    public void UpdateAnimation4()
    {
        _animator.SetBool("next4", true);
    }
   
    
    // Function to make the character walk out of the screen
    public void WalkOutOfScreen()
    {
        StartCoroutine(MoveCharacter());
    }

    private IEnumerator MoveCharacter()
    {
        // Calculate the target position off the screen (e.g., left of the screen)
        float targetX = -GetComponent<SpriteRenderer>().bounds.extents.x;

        // Continue moving until the character is out of the screen
        while (transform.position.x > targetX)
        {
            // Move the character towards the left
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            yield return null;
        }

        // Character is out of the screen, you can disable or destroy the character at this point
        gameObject.SetActive(false);
    }
}

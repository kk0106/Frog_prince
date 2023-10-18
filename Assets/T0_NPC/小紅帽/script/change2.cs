using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change2 : MonoBehaviour
{
    public float speed = 5.0f; // Speed at which the character moves
    private Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void UpdateAnimation2()
    {
        _animator.SetBool("next2", true);
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

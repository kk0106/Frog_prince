using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField] private float MoveSpeed=7.5f;
    private Rigidbody rb;
    private float moveInput;

    private Vector3 player00;

    private bool FaceRight;
    // Start is called before the first frame update
    private void Start()
    {
        rb= GetComponent<Rigidbody>();
        FaceRight = true;
      
        StartDirectionCheck();
    }

    // Update is called once per frame
 
    private void Update()
    {
        Move();
       
    }

    private void Move()
    {
        moveInput = UserInput.instance.moveInput.x;
        if(moveInput >0 || moveInput < 0)
        {
            TurnCheck();    
        }
        rb.velocity = new Vector2 (moveInput*MoveSpeed,rb.velocity.y);
    }
    
    private void StartDirectionCheck()
    {
        if(player00.x>0)
        {
            FaceRight = true;
        }
        else
        {
            FaceRight= false;
        }
    }

    private void TurnCheck()
    {
        if (UserInput.instance.moveInput.x > 0 && !FaceRight)
        {
            Turn();
        }
        else if (UserInput.instance.moveInput.x < 0 && FaceRight)
        {
            Turn();
        }
    }

    private void Turn()
    {
        if (FaceRight)
        {
            Vector3 rotator = new Vector3 (transform.rotation.x,180f,transform.rotation.z);
            transform.rotation=Quaternion.Euler(rotator);
            FaceRight = !FaceRight;
        }
        else
        {
            Vector3 rotator = new Vector3(transform.rotation.x, 0f, transform.rotation.z);
            transform.rotation = Quaternion.Euler(rotator);
            FaceRight = !FaceRight;
        }
    }
}

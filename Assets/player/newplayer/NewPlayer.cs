using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewPlayer : MonoBehaviour
{
    Vector3 currentMovement;

    [Header("ground check")]
    public LayerMask WhatIsGround;
    public Transform GroundPoint;
    public bool IsGrounded;

    [Header("Movement")]
    [SerializeField] public float MoveSpeed;
    [SerializeField] public bool FaceRight;
    private float moveInput;
    private Rigidbody rb;

    [Header("Jump")]
   public bool isJumpPressed=false;
    public float jumpForce=10;
    public bool isJumping=false;
    public float jumpHeight;

   public  Vector3 gravityScale ;
   public Vector3 fallGravityScale ;


    // Start is called before the first frame update

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        MoveSpeed = 2f;

        FaceRight = true;
    }

    private void FixedUpdate()
    {
        if (UserInput.instance.moveInput.x < 0 && FaceRight)
        {
            filpPlayer();
        }
        else if (UserInput.instance.moveInput.x > 0 && !FaceRight)
        {
            filpPlayer();
        }
    }

    void filpPlayer()
    {
        FaceRight = !FaceRight;

        Vector3 localScale= transform.localScale;
        localScale.x *= -1f;  

        transform.localScale = localScale;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
       
        if(IsGrounded&&isJumpPressed)
        {
         //   Physics.gravity = gravityScale;
          //  float jumpForce =Mathf.Sqrt(jumpHeight*(Physics.gravity.y*gravityScale.y)*-2)*rb.mass;
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        if (rb.velocity.y > 0)
        {
            Physics.gravity = gravityScale;
        }
        else
        {
            Physics.gravity = fallGravityScale;
        }

        if (UserInput.instance.controls.playerControls.jump.WasPressedThisFrame())
        {
            isJumpPressed = true;
        }
        if (UserInput.instance.controls.playerControls.jump.WasReleasedThisFrame())
        {
            isJumpPressed = false;
        }



        RaycastHit hit;
        if (Physics.Raycast(GroundPoint.position, Vector3.down, out hit, .3f, WhatIsGround))
        {
            IsGrounded = true;
        }
        else
        {
            IsGrounded = false;
        }
    }
    private void Move()
    {
        
            moveInput = UserInput.instance.moveInput.x;
            rb.velocity = new Vector3(moveInput * MoveSpeed, rb.velocity.y);
    }

   
    
    
}

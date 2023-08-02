using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class player : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float MoveSpeed = 7.5f;
    [SerializeField] public bool FaceRight;
    private Vector3 player00;
    private Animator move_ani;

    [Header("Jump")]
    [SerializeField] private float JumpForce = 5f;
    [SerializeField] private float JumpTime = 0.5f;
    public bool Jumping;
    public bool Falling;
    private float JumpTimeCounter;

    [Header("camera")]
    [SerializeField] private GameObject _cameraGo;
    [SerializeField] private CameraFollowObject _CamerafollowObject;

    [Header("ground check")]
    //private Collider coll;
    //[SerializeField]private float groundCheckOffest = 0f;
    // [SerializeField]private float groundCheckDistance = 0.4f;
    //[SerializeField] private float groundCheckRidious = 0.25f;
    //[SerializeField] private LayerMask WhatIsGround;

  

    public bool grouned=false;

    private float moveInput;
    private Rigidbody rb;

    //地板確認
    private void OnCollisionEnter(Collision collision)
    {
        grouned = true;
    }
    private void OnCollisionExit(Collision collision) 
    {
        grouned = false;
    }
    private bool CheckForLand()
    {
        if (Falling)
        {
            if (grouned)
            {
                Falling = false;

                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }







    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        move_ani = GetComponent<Animator>();
        //coll = GetComponent<Collider>();

        StartDirectionCheck();

        _CamerafollowObject = _cameraGo.GetComponent<CameraFollowObject>();
    }

    // Update is called once per frame

    private void Update()
    {
        Move();
        Jump();
        move1();
        
    }

    private void Jump()
    {
        //按一次跳鍵
        if (UserInput.instance.controls.playerControls.jump.WasPressedThisFrame()&&grouned)
        {
            JumpTimeCounter = JumpTime;
            Jumping = true;
            rb.velocity = new Vector2(rb.velocity.x, JumpForce);
            move_ani.SetTrigger("jump");
        }

        //持續按著跳鍵
        if (UserInput.instance.controls.playerControls.jump.IsPressed())
        {
            if (JumpTime > 0 && Jumping)
            {
                rb.velocity = new Vector2(rb.velocity.x, JumpForce);
                JumpTime -= Time.deltaTime;

            }

            else if(JumpTimeCounter==0)
            {
                Falling = true;
                Jumping = false;
                JumpTime = 0.36f;
            }
            else
            {
                Jumping=false;
            }

        }

        //釋放跳鍵
        if (UserInput.instance.controls.playerControls.jump.WasReleasedThisFrame())
        {
            Jumping = false;
            Falling = true;
        }
        
        if(!Jumping && CheckForLand())
        {
            move_ani.SetTrigger("land");
        }
    }

    private void Move()
    {
        moveInput = UserInput.instance.moveInput.x;
        if (moveInput > 0 || moveInput < 0)
        {
            move_ani.SetBool("IsWalk_Right", true);
            TurnCheck();

        }

        else
        {
            move_ani.SetBool("IsWalk_Right", false);
        }
        rb.velocity = new Vector3(moveInput * MoveSpeed, rb.velocity.y,0);
    }

    private void StartDirectionCheck()
    {
        if (player00.x > 0)
        {
            FaceRight = true;
        }
        else
        {
            FaceRight = false;
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
            Vector3 rotator = new Vector3(transform.rotation.x, 180f, transform.rotation.z);
            transform.rotation = Quaternion.Euler(rotator);
            FaceRight = !FaceRight;

            _CamerafollowObject.CallTurn();
        }
        else
        {
            Vector3 rotator = new Vector3(transform.rotation.x, 0f, transform.rotation.z);
            transform.rotation = Quaternion.Euler(rotator);
            FaceRight = !FaceRight;


            _CamerafollowObject.CallTurn();
        }
    }

   private void move1()
    {
       moveInput = UserInput.instance.moveInput.y;
        //rb.velocity = new Vector3(moveInput * MoveSpeed, 0,rb.velocity.z);
      
    }


}

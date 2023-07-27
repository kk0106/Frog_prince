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

    public float distance;//偵測與地板的距離
    public Transform groundCheck;//偵測地板射線起點
    public LayerMask groundLayer;//地面圖層
    public bool grounded;

    private float moveInput;
    private Rigidbody rb;









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
    }

    private void Jump()
    {
        //按一次跳鍵
        if (UserInput.instance.controls.playerControls.jump.WasPressedThisFrame() )
        {
            JumpTimeCounter = JumpTime;
            Jumping = true;
            rb.velocity = new Vector2(rb.velocity.x, JumpForce);
        }

        //持續按著跳鍵
        if (UserInput.instance.controls.playerControls.jump.IsPressed())
        {
            if (JumpTime > 0 && Jumping)
            {
                rb.velocity = new Vector2(rb.velocity.x, JumpForce);
                JumpTime -= Time.deltaTime;

            }

            else
            {
                Jumping = false;
                JumpTime = 0.36f;
            }

        }

        //釋放跳鍵
        if (UserInput.instance.controls.playerControls.jump.WasReleasedThisFrame())
        {
            Jumping = false;
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
        rb.velocity = new Vector2(moveInput * MoveSpeed, rb.velocity.y);
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



}

using Ink.Parsed;
using Ink.Runtime;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.ProBuilder.MeshOperations;

public class player : MonoBehaviour
{
    private Animator ani;

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
    public bool isJumpPressed = false;
    public float jumpForce;
    public float jf1;
    public float jf2;
    public bool isJumping = false;
    public float jumpHeight;

    public Vector3 gravityScale;
    public Vector3 fallGravityScale;

    AudioManager audioManager;

   
    

   

    public uiMenu uiMenu;

    public GameObject BackPack;
    bool areOpen;
    [SerializeField] private DialogueUI dialogueUI;


    public DialogueUI DialogueUI
    {
        get { return dialogueUI; }
        set { dialogueUI = value; }
    }

    public void SetDialogueUI(DialogueUI newDialogueUI)
    {
        dialogueUI = newDialogueUI;
    }

    public IInteractable Interactable { get; set; }


    // Start is called before the first frame update
    private void Start()
    {
        ani = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        MoveSpeed = 2f;

        FaceRight = true;
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
        

        BackPack.SetActive(false);
    }

    // Update is called once per frame

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

        Vector3 localScale = transform.localScale;
        localScale.x *= -1f;

        transform.localScale = localScale;
    }


    private void Update()
    {

        Move();

        if (GrapplingGun.grappleCheck == 1)
        {
            ani.SetBool("tongue", true);
        }
        if (GrapplingGun.grappleCheck == 0)
        {
            ani.SetBool("tongue", false);
        }


        if (IsGrounded && isJumpPressed)
        {
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
        if (UserInput.instance.controls.playerControls.jump.IsPressed())
        {
            jumpForce = jf1;

        }
        else if (UserInput.instance.controls.playerControls.jump.WasReleasedThisFrame())
        {
            jumpForce = jf2;
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


        Invoke("alife", 1f);
        if (uiMenu.Opened) return;
        if (dialogueUI.IsOpen) return;
        OpenBackPack();
        if (areOpen == true) return;
      

        if (UserInput.instance.controls.playerControls.talk.WasPressedThisFrame())
    
            {
            if (dialogueUI.IsOpen) return;
            Interactable?.Interact(this);
            }


        
    }


    private void Move()
    {

        moveInput = UserInput.instance.moveInput.x;
        rb.velocity = new Vector3(moveInput * MoveSpeed, rb.velocity.y);

        if (moveInput > 0 || moveInput < 0)
        {

            ani.SetBool("walk", true);

        }
        else
        {
            ani.SetBool("walk", false);
        }

    }






    void OpenBackPack()
    {
        if (UserInput.instance.controls.playerControls.BackPack.WasPressedThisFrame())
        {
            areOpen = !areOpen;
            BackPack.SetActive(areOpen);
        }
    }


}

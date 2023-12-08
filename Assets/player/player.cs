using Ink.Parsed;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class player : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] public static float MoveSpeed ;
    [SerializeField] private float MoveSpeed1 ;
    [SerializeField] public bool FaceRight;
    [SerializeField] public bool FaceBack;
    
    private Vector3 player00;
    private Animator move_ani;

    public GameObject InMermaid;
    public float InMermaidSpeed;


    [Header("Jump")]
    [SerializeField] public static float JumpForce = 3f;
    [SerializeField] private float JumpTime = 0.35f;
    public bool Jumping;
    public bool Falling;
    private float JumpTimeCounter;
    public float y;

    [Header("camera")]
    [SerializeField] private GameObject _cameraGo;
    [SerializeField] private CameraFollowObject _CamerafollowObject;

    [Header("ground check")]
    public LayerMask WhatIsGround;
    public Transform GroundPoint;
    private bool IsGrounded;

    [Header("Mushroom")]
    public float MushJumpForce;
    public float MushJumpForce1;
    public float MushJumpForce2;
    public static int B;


    private float moveInput;
    private float moveInput1;
    private Rigidbody rb;

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
        rb = GetComponent<Rigidbody>();
        move_ani = GetComponent<Animator>();

        

        StartDirectionCheck();
        StartDirectionCheck1();

        _CamerafollowObject = _cameraGo.GetComponent<CameraFollowObject>();

        BackPack.SetActive(false);
    }

    // Update is called once per frame

    private void Update()
    {


       
        Invoke("alife", 1f);
        if (uiMenu.Opened) return;
        if (dialogueUI.IsOpen) return;
        OpenBackPack();
        if (areOpen == true) return;
        Move();

        Jump();

       

     
        
        if (rbcomic.A == 1)
        {
            MoveSpeed = 0;
            MoveSpeed1 = 0;
            JumpForce = 0;
            
        }
        else if (GrapplingGun.IsSwinging == 1)
        {
            MoveSpeed = 2.5f;
            MoveSpeed1 = 2.5f;

            JumpForce = 3f;
             

        }
        else
        {
            MoveSpeed=2f;
            MoveSpeed1 = MoveSpeed;
            

            JumpForce = 3f;

            if (InMermaid.activeInHierarchy)
            {
                MoveSpeed = InMermaidSpeed;
                MoveSpeed1 = MoveSpeed;

              //  JumpForce = 10f;

            
            }

        }
        
        if (UserInput.instance.controls.playerControls.talk.WasPressedThisFrame())
    
            {
            if (dialogueUI.IsOpen) return;
            Interactable?.Interact(this);
            }

        if (GrapplingGun.grappleCheck == 1 && FaceRight)
        {
            move_ani.SetBool("IsTongueR", true);
        }
        if (GrapplingGun.grappleCheck == 0 && FaceRight)
        {
            move_ani.SetBool("IsTongueR", false);
        }
        if (GrapplingGun.grappleCheck == 1 && !FaceRight)
        {
            move_ani.SetBool("IsTongueL", true);
        }
        if (GrapplingGun.grappleCheck == 0 && !FaceRight)
        {
            move_ani.SetBool("IsTongueL", false);
        }

        

        if (!IsGrounded)
        {
            JumpTime -= Time.deltaTime;
        }
        if (IsGrounded)
        {
            JumpTime = 0.36f;
        }



        RaycastHit hit;
        if(Physics.Raycast(GroundPoint.position,Vector3.down,out hit,.3f,WhatIsGround))
        {
            IsGrounded = true;
        }
        else
        {
            IsGrounded = false;
        }


      
        
    }


    //腳色跳躍設定
    private void Jump()
    {
        //按一次跳鍵
        if (UserInput.instance.controls.playerControls.jump.WasPressedThisFrame()&&IsGrounded)
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
                

            }


        }

        //釋放跳鍵
        if (UserInput.instance.controls.playerControls.jump.WasReleasedThisFrame())
        {
            Jumping = false;
            Falling = true;
        }
      
    }



    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "Mushroom")
        {

            rb.velocity = new Vector3(rb.velocity.y, MushJumpForce);
            

          //  rb.AddForce(Vector3.up * 150f);

        }

        if (other.gameObject.tag == "MushroomA")
        {

            rb.velocity = new Vector3(rb.velocity.y, MushJumpForce1);

        }

        if(other.gameObject.tag== "MushroomB")
        {
            rb.velocity = new Vector3(rb.velocity.y, MushJumpForce2);
        }

        if(other.gameObject.tag== "MushroomC")
        {
            rb.velocity = new Vector3(rb.velocity.y, MushJumpForce);
        }
    }
    

    private void alife()
    {
        if (gameObject.tag == "MushroomC")
        {
            gameObject.SetActive(true);
        }
    }

    private void OnCollisionExit(Collision other)
    {

        if (other.gameObject.tag == "MushroomC")
        {
         other.gameObject.SetActive(false);
            
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Trident")
        {
            print("1");
        }
    }

  

    //腳色移動設定

    
   
    private void Move()
    {
        moveInput = UserInput.instance.moveInput.x;
        moveInput1=UserInput.instance.moveInput.y;
        if (moveInput > 0 || moveInput < 0)
        {
            move_ani.SetBool("IsWalk_Right", true);
            TurnCheck();

        }

        else
        {
            move_ani.SetBool("IsWalk_Right", false);
        }

        if(moveInput1> 0 || moveInput1<0)
        {
            TurnCheck1();
            move_ani.SetBool("IsWalk_Back", true);
            
        }
        else
        {
            move_ani.SetBool("IsWalk_Back", false);
        }

        rb.velocity = new Vector3(moveInput * MoveSpeed, rb.velocity.y,moveInput1*MoveSpeed1);
    }
    //偵測腳色是否面向右邊
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

    //偵測腳色是否面向後方
    private void StartDirectionCheck1()
    {
        if (player00.z > 0)
        {
            FaceBack = true;
        }
        else
        {
            FaceBack = false;
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

    private void TurnCheck1()
    {
        if (UserInput.instance.moveInput.y > 0 && !FaceBack)
        {
            Turn1();
        }
        else if (UserInput.instance.moveInput.y < 0 && FaceBack)
        {
            Turn1();
        }
    }

    //更改腳色面向
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


    private void Turn1()
    {
        if (FaceBack)
        {
            Vector3 rotator = new Vector3(transform.rotation.x, 25f, transform.rotation.z);
            transform.rotation = Quaternion.Euler(rotator);
            FaceBack = !FaceBack;

            
        }
        else
        {
            Vector3 rotator = new Vector3(transform.rotation.x, -25f, transform.rotation.z);
            transform.rotation = Quaternion.Euler(rotator);
            FaceBack = !FaceBack;

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

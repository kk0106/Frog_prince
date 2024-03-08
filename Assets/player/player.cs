using Ink.Parsed;
using Ink.Runtime;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.ProBuilder.MeshOperations;

public class player : MonoBehaviour
{
    [Header("z-axis")]
   
    public float minValue;
    public float maxValue;

    [Header("T1 z-axis")]
    public GameObject InT1;

    [Header("Movement")]
    [SerializeField] public static float MoveSpeed ;
    [SerializeField] private float MoveSpeed1 ;
    [SerializeField] public bool FaceRight;
    [SerializeField] public bool FaceBack;
    
    private Vector3 player00;
    private Animator move_ani;

    [Header("Mermaid")]
    public GameObject InMermaid;
    public float InMermaidSpeed;
    public float InMermaidJumpForce;
    AudioManager audioManager;

    [Header("Jump")]
    [SerializeField] public static float JumpForce = 3f;
    [SerializeField] private float JumpTime = 0.35f;
    public bool Jumping;
    public bool Falling;
    private float JumpTimeCounter;
    public float y;
    public static bool LongJump;

    [SerializeField] float jumpHeight=5;
    [SerializeField] Vector3 gravityScale ;
    [SerializeField] Vector3 fallGravityScale ;

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
        LongJump = false;

        rb = GetComponent<Rigidbody>();
        move_ani = GetComponent<Animator>();
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
        

        StartDirectionCheck();
        StartDirectionCheck1();

        _CamerafollowObject = _cameraGo.GetComponent<CameraFollowObject>();

        BackPack.SetActive(false);
    }

    // Update is called once per frame

    private void Update()
    {
        
        if (CardStartTriggerValue.start == 1|| NewT0toT1.a == 1|| eggTip.IsTip == 1||shoose.isEnd==1)
        {
            MoveSpeed = 0;
            MoveSpeed1 = 0;

            JumpForce = 0;
        }

        if (ismushroom.ismushrooma==1)
        {
            maxValue = -43.8f;
            minValue = -48f;
        }

        if (InT1.activeInHierarchy)
        {
            maxValue = -45.98f;
            minValue = -45.98f;
        }

       
      /*  else
        {
            MoveSpeed = 2f;
            MoveSpeed1 = 2f;

            JumpForce = 3f;
        }*/

        Vector3 currentPosition = transform.position;

        // 限制Z??值在指定范??
        currentPosition.z = Mathf.Clamp(currentPosition.z, minValue, maxValue);

        // ?新的位置?用到玩家?象上
        transform.position = currentPosition;



        Invoke("alife", 1f);
        if (uiMenu.Opened) return;
        if (dialogueUI.IsOpen) return;
        OpenBackPack();
        if (areOpen == true) return;
        Move();

        Jump();


        if (T1EndRb.a == 1)
        {
          InMermaid.SetActive(true);
        }




        if (RedApplee.IsRedCom == 1)
        {
            MoveSpeed = 0;
            MoveSpeed1 = 0;
            JumpForce = 0;
        }

        else if (GrapplingGun.IsSwinging == 1)
        {
            MoveSpeed = 2.5f;
            MoveSpeed1 = 2.5f;

            JumpForce = 2f;


        }
        else
        {
            MoveSpeed = 2f;
            MoveSpeed1 = MoveSpeed;


            JumpForce = 2f;


            if (InMermaid.activeInHierarchy)
            {
                MoveSpeed = InMermaidSpeed;
                MoveSpeed1 = MoveSpeed;

                JumpForce = InMermaidJumpForce;


                minValue = -80;
                maxValue = -40f;
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


       
            move_ani.SetFloat("x", UserInput.instance.moveInput.x);
        
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
           AudioManager.Instance.PlaySFX(AudioManager.Instance.jump);


          //  Physics.gravity = gravityScale;
           // float jumpForce = Mathf.Sqrt((jumpHeight * (Physics.gravity.y *-9.18f)*- 2) * rb.mass);
         //   rb.AddForce(Vector2.up * jumpForce, ForceMode.Impulse);


        }
        if (rb.velocity.y > 0)
        {
            Physics.gravity = gravityScale;
        }

        if (rb.velocity.y < 0)
        {
            Physics.gravity = fallGravityScale;
        }


        //持續按著跳鍵
        if (UserInput.instance.controls.playerControls.jump.IsPressed())
        {
            if (JumpTime > 0 && Jumping)
            {
                rb.velocity = new Vector2(rb.velocity.x, JumpForce);

                LongJump = true;
            }


        }

        //釋放跳鍵
        if (UserInput.instance.controls.playerControls.jump.WasReleasedThisFrame())
        {
            Jumping = false;
            Falling = true;


            LongJump = false;
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
       /*  if (moveInput > 0 )
          {
             move_ani.SetBool("IsWalk_Right", true);
             // move_ani.SetBool("IsWalk_Back", false);
              TurnCheck();

          }
        if (moveInput < 0)
        {
             // move_ani.SetBool("IsWalk_Right", false);
           /  move_ani.SetBool("IsWalk_Back", true);
            TurnCheck();
        }

        /*if (moveInput == 0)
        {
            move_ani.SetBool("IsWalk_Back", false);

            move_ani.SetBool("IsWalk_Right", false);
            if (FaceRight)
            {
                move_ani.SetBool("Is_Left_Idle", false);
            }
            else
            {
                move_ani.SetBool("Is_Left_Idle", true);
            }

        }*/

        

           if(moveInput> 0 || moveInput<0)
          {
              TurnCheck();
              move_ani.SetBool("IsWalk_Right", true);

          }
          else
          {
              move_ani.SetBool("IsWalk_Right", false);
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


           // if(UserInput.instance.moveInput.x == 0)
            //{
              //  move_ani.SetBool("Is_Left_Idle", true);
            //}
           // move_ani.SetBool("Is_Left_Idle", false);
            // move_ani.SetBool("IsWalk_Right", false);
            // move_ani.SetBool("IsWalk_Back", true);
           _CamerafollowObject.CallTurn();
        }
        else
        {
            Vector3 rotator = new Vector3(transform.rotation.x, 0f, transform.rotation.z);
            transform.rotation = Quaternion.Euler(rotator);
            FaceRight = !FaceRight;

            //if (UserInput.instance.moveInput.x == 0)
            //{
              //  move_ani.SetBool("Is_Left_Idle", false);
            //}

            // move_ani.SetBool("Is_Left_Idle", false);
            //move_ani.SetBool("IsWalk_Back", false);
            //move_ani.SetBool("IsWalk_Right", true);
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

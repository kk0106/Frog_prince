using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class player : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] public static float MoveSpeed = 7.5f;
    [SerializeField] private float MoveSpeed1 = 7.5f;
    [SerializeField] public bool FaceRight;
    [SerializeField] public bool FaceBack;
    private Vector3 player00;
    private Animator move_ani;
    

    [Header("Jump")]
    [SerializeField] public static float JumpForce = 5f;
    [SerializeField] private float JumpTime = 0.5f;
    public bool Jumping;
    public bool Falling;
    private float JumpTimeCounter;

    [Header("camera")]
    [SerializeField] private GameObject _cameraGo;
    [SerializeField] private CameraFollowObject _CamerafollowObject;

    [Header("ground check")]
     public bool grouned=false;

    private float moveInput;
    private float moveInput1;
    private Rigidbody rb;

    public GameObject GamePenal;
    
    [SerializeField] private DialogueUI dialogueUI;

    public DialogueUI DialogueUI => dialogueUI;

    public IInteractable Interactable { get; set; }


    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        move_ani = GetComponent<Animator>();
        //coll = GetComponent<Collider>();

        StartDirectionCheck();
        StartDirectionCheck1();

        _CamerafollowObject = _cameraGo.GetComponent<CameraFollowObject>();
    }

    // Update is called once per frame

    private void Update()
    {
        if (dialogueUI.IsOpen) return;

        Move();
        Jump();
        
        if(GamePenal.activeInHierarchy)
        {
            MoveSpeed = 0f;
            MoveSpeed1 = 0f;
            JumpForce = 0f;
        }
        else
        {
            MoveSpeed = 1.5f;
            MoveSpeed1 = 1.5f;
            JumpForce = 3f;
        }
        
        if (UserInput.instance.controls.playerControls.talk.WasPressedThisFrame())
        
      
            {
            if (dialogueUI.IsOpen) return;
            Interactable?.Interact(this);
            }
        

    }


    //腳色跳躍設定
    private void Jump()
    {
        //按一次跳鍵
        if (UserInput.instance.controls.playerControls.jump.WasPressedThisFrame()&&grouned)
        {
            JumpTimeCounter = JumpTime;
            Jumping = true;
            rb.velocity = new Vector2(rb.velocity.x, JumpForce);
           // move_ani.SetTrigger("jump");
        }

        //持續按著跳鍵
        if (UserInput.instance.controls.playerControls.jump.IsPressed())
        {
            if (JumpTime > 0 && Jumping)
            {
                rb.velocity = new Vector2(rb.velocity.x, JumpForce);
                JumpTime -= Time.deltaTime;

            }

            //else if(JumpTimeCounter==0)
           // {
           //     Falling = true;
           //     Jumping = false;
          //      JumpTime = 0.36f;
          //  }
            else
            {
                Jumping=false;
                JumpTime = 0.36f;
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
         //   move_ani.SetTrigger("land");
        }
    }


    //腳色是否在地面上
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
            Vector3 rotator = new Vector3(transform.rotation.x, 90f, transform.rotation.z);
            transform.rotation = Quaternion.Euler(rotator);
            FaceBack = !FaceBack;

            
        }
        else
        {
            Vector3 rotator = new Vector3(transform.rotation.x, -90f, transform.rotation.z);
            transform.rotation = Quaternion.Euler(rotator);
            FaceBack = !FaceBack;

        }
    }




}

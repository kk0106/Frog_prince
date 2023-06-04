using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class test : MonoBehaviour
{

    Rigidbody playerRigidbody;//�]�w�}�����

    public Vector2 moveVector;
    

    public float yForce;//�������O
    public float YYForce;
    public float speed;
   
    public float distance;//�����P�a�O���Z��
    public Transform groundCheck;//�����a�O�g�u�_�I
    public LayerMask groundLayer;//�a���ϼh
    public bool grounded;

    bool IsGround//���a���󩳳����@�ӫܵu���g�u�A�����g�u�O�_����a�O�ϼh�A�����ܥN���b�a��
    {
        get
        {
            Vector3 start = groundCheck.position;
            Vector3 end = new Vector3(start.x, start.y - distance, start.z);
            Debug.DrawLine(start, end, Color.blue);
            grounded = Physics.Linecast(start, end, groundLayer);
            return grounded;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();//�����������}�⪺RIGDIBODY

        
    }

    // Update is called once per frame
    void Update()
    {
        if (moveVector != Vector2.zero)
        {
            this.transform.position += new Vector3(moveVector.x, 0, moveVector.y) *speed* Time.deltaTime;
        }
        
    }
    public void jump(InputAction.CallbackContext ctx)
    {
     
        if (ctx.started&&IsGround)
        {
            playerRigidbody.AddForce(Vector3.up * yForce);
        }
        
    }
    public void Movement(InputAction.CallbackContext ctx)
    {

        
          moveVector = ctx.ReadValue<Vector2>();
            //print(moveVector);
        
    }
    public void longJump(InputAction.CallbackContext ctx)
    {

        if (ctx.performed && IsGround)
        {
            playerRigidbody.AddForce(Vector3.up * YYForce);
        }

    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;



public class player_move : MonoBehaviour
{
    Rigidbody playerRigidbody;


    public float maxSpeedX;//����̰��������ʼƭ�
    public float maxSpeedZ;//����̰��e�Ჾ�ʼƭ�

    float speedX;// �ثe�����t��
    float speedY;//�ثe�����t��
    float speedZ;//�ثe�e��t��

    public float horizontalDirection;// �ثe������V
    public float verticalDirection;//�e���V

    const string HORIZONTAL = "Horizontal";// �������
    const string VERTICAL = "Vertical";

    public float xForce;//�������O
    public float yForce;//�������O
    public float zForce;//�e����O

    public float distance;//�����P�a�O���Z��

    public Transform groundCheck;//�����a�O�g�u�_�I
    public LayerMask groundLayer;//�a���ϼh

    public bool grounded;

    bool IsGround//���a���󩳳����@�ӫܵu���g�u�A�����g�u�O�_����a�O�ϼh�A�����ܥN���b�a��
    {
        get
        {
            Vector3 start = groundCheck.position;
            Vector3 end = new Vector3(start.x, start.y-distance, start.z);
            Debug.DrawLine(start, end, Color.blue);
            grounded=Physics.Linecast(start, end,groundLayer);
            return grounded;
        }
    }

    public bool JumpKey//�����O�_�������D��
    {
        get
        {
            return Input.GetKeyDown(KeyCode.Space);

        }
    }

    void jump()//���D
    {
        if(IsGround&&JumpKey)
        {
            playerRigidbody.AddForce(Vector3.up*yForce);
        }
    }




    public void ControlSpeed()//����ثe�t�צbMAXSPEED�d��
    {
        speedX=playerRigidbody.velocity.x;
        speedY=playerRigidbody.velocity.y;
       
        float newSpeedX = Mathf.Clamp(speedX, -maxSpeedX, maxSpeedX);//���t�ƶȥN���V��
       
        playerRigidbody.velocity = new Vector3(newSpeedX,speedY,0);
    }

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();//�����������}�⪺RIGDIBODY
    }

    void movementX()//��������
    {
        horizontalDirection=Input.GetAxis(HORIZONTAL);
        playerRigidbody.AddForce(new Vector3(xForce * horizontalDirection, 0, 0));
    }

    void movementZ()//��������
    {
        verticalDirection = Input.GetAxis(VERTICAL);
        playerRigidbody.AddForce(new Vector3(0, 0, zForce * verticalDirection));
    }


    void Update()
    {
        movementX();
        movementZ();
        ControlSpeed();
        jump();

    }
  
}

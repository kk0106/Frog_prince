using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;



public class player_move : MonoBehaviour
{
    Rigidbody playerRigidbody;


    public float maxSpeedX;//限制最高水平移動數值
    public float maxSpeedZ;//限制最高前後移動數值

    float speedX;// 目前水平速度
    float speedY;//目前垂直速度
    float speedZ;//目前前後速度

    public float horizontalDirection;// 目前水平方向
    public float verticalDirection;//前後方向

    const string HORIZONTAL = "Horizontal";// 水平控制器
    const string VERTICAL = "Vertical";

    public float xForce;//水平推力
    public float yForce;//垂直推力
    public float zForce;//前後推力

    public float distance;//偵測與地板的距離

    public Transform groundCheck;//偵測地板射線起點
    public LayerMask groundLayer;//地面圖層

    public bool grounded;

    bool IsGround//玩家物件底部有一個很短的射線，偵測射線是否打到地板圖層，有的話代表踩在地面
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

    public bool JumpKey//偵測是否有按跳躍鍵
    {
        get
        {
            return Input.GetKeyDown(KeyCode.Space);

        }
    }

    void jump()//跳躍
    {
        if(IsGround&&JumpKey)
        {
            playerRigidbody.AddForce(Vector3.up*yForce);
        }
    }




    public void ControlSpeed()//控制目前速度在MAXSPEED範圍內
    {
        speedX=playerRigidbody.velocity.x;
        speedY=playerRigidbody.velocity.y;
       
        float newSpeedX = Mathf.Clamp(speedX, -maxSpeedX, maxSpeedX);//正負數僅代表方向性
       
        playerRigidbody.velocity = new Vector3(newSpeedX,speedY,0);
    }

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();//偵測場景中腳色的RIGDIBODY
    }

    void movementX()//水平移動
    {
        horizontalDirection=Input.GetAxis(HORIZONTAL);
        playerRigidbody.AddForce(new Vector3(xForce * horizontalDirection, 0, 0));
    }

    void movementZ()//垂直移動
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

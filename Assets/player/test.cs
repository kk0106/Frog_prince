using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class test : MonoBehaviour
{

    Rigidbody playerRigidbody;//設定腳色鋼體

    public Vector2 moveVector;
    

    public float yForce;//垂直推力
    public float YYForce;
    public float speed;
   
    public float distance;//偵測與地板的距離
    public Transform groundCheck;//偵測地板射線起點
    public LayerMask groundLayer;//地面圖層
    public bool grounded;

    bool IsGround//玩家物件底部有一個很短的射線，偵測射線是否打到地板圖層，有的話代表踩在地面
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
        playerRigidbody = GetComponent<Rigidbody>();//偵測場景中腳色的RIGDIBODY

        
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

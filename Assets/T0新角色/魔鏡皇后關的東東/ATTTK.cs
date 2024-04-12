using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ATTTK : MonoBehaviour
{
        
    public float speed = 5.0f; // 前進的速度
    public Vector2 targetDirection = Vector2.right; // 指定的 xy 平面夾角向量
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
        // 計算目標向量的角度
        float angle = Mathf.Atan2(targetDirection.y, targetDirection.x) * Mathf.Rad2Deg;

        // 設置物體的旋轉
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        // 將物體沿著自身的前方向前進
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}

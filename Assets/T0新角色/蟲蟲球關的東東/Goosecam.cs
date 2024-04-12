using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goosecam : MonoBehaviour
{
    public Quaternion fixedRotation = Quaternion.Euler(0, 0, 8.13f);
    public float speed = 5.0f; // 前進的速度
    public Vector2 targetDirection = Vector2.right; // 指定的 xy 平面夾角向量
    public GameObject player;
    public Vector3 player_pos;
    private float x;
    private float z;
    public float y;
    public float a;
    void Update()
    {
        this.gameObject.transform.rotation = fixedRotation;
        // 計算目標向量的角度
        float angle = Mathf.Atan2(targetDirection.y, targetDirection.x) * Mathf.Rad2Deg;

        // 設置物體的旋轉
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        // 將物體沿著自身的前方向前進
        transform.Translate(Vector3.right * speed * Time.deltaTime);

        player_pos = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);


        this.gameObject.transform.position = player_pos;
    }

   
}

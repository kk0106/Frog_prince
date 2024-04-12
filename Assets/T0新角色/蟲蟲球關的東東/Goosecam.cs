using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goosecam : MonoBehaviour
{
    public Quaternion fixedRotation = Quaternion.Euler(0, 0, 8.13f);
    public float speed = 5.0f; // �e�i���t��
    public Vector2 targetDirection = Vector2.right; // ���w�� xy ���������V�q
    public GameObject player;
    public Vector3 player_pos;
    private float x;
    private float z;
    public float y;
    public float a;
    void Update()
    {
        this.gameObject.transform.rotation = fixedRotation;
        // �p��ؼЦV�q������
        float angle = Mathf.Atan2(targetDirection.y, targetDirection.x) * Mathf.Rad2Deg;

        // �]�m���骺����
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        // �N����u�ۦۨ����e��V�e�i
        transform.Translate(Vector3.right * speed * Time.deltaTime);

        player_pos = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);


        this.gameObject.transform.position = player_pos;
    }

   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ATTTK : MonoBehaviour
{
        
    public float speed = 5.0f; // �e�i���t��
    public Vector2 targetDirection = Vector2.right; // ���w�� xy ���������V�q
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
        // �p��ؼЦV�q������
        float angle = Mathf.Atan2(targetDirection.y, targetDirection.x) * Mathf.Rad2Deg;

        // �]�m���骺����
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        // �N����u�ۦۨ����e��V�e�i
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}

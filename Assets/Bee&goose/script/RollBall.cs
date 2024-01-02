using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollBall : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    public float minValue;
    public float maxValue;
    // Start is called before the first frame update
    void Start()
    {
        rb=gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       // rb.velocity = Vector3.left*speed;

       rb.AddForce(Vector3.left*speed);


        Vector3 currentPosition = transform.position;

        // 限制Z??值在指定范??
        currentPosition.z = Mathf.Clamp(currentPosition.z, minValue, maxValue);

        // ?新的位置?用到玩家?象上
        transform.position = currentPosition;
    }
}

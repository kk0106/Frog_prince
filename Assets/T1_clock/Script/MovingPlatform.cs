using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    private Rigidbody platformRigid;
    [Header("MovingFromTwoPos")]
    private GameObject Target;
    public int targetNumber;
    [SerializeField]
    private GameObject[] position;
    [Header("BasicValue")]
    [SerializeField]
    private float speed;

    public bool Trigger;
    private void Start()
    {
        Target = position[targetNumber];
        platformRigid = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        if (Trigger)
        {
            Vector3 StartPosition = this.transform.position;
            Vector3 Direction = Target.transform.position - StartPosition;
            platformRigid.velocity = Direction * speed;
        }
    }

    public void PositionMoveTo(int PositionID)
    {
        targetNumber = PositionID;

        if (position[targetNumber] != null)
        {
            Target = position[targetNumber];
        }
        else
        {
            Target = position[0];
            targetNumber = 0;
        }
    }

    public void StartMove()
    {
        Trigger = true;
    }
    public void StopMove()
    {
        Trigger = false;
    }
}
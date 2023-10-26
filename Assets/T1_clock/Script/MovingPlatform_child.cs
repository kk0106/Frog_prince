using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform_child : MonoBehaviour
{
    [SerializeField]
    private MovingPlatform movingPlatform;
    [Header("basicValue")]
    [SerializeField]
    private int PositionID;
    [SerializeField]
    private float stayTime;
    [SerializeField]
    private float maxStayTime;
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "MovingPlatform" && movingPlatform.targetNumber == PositionID)
        {
            stayTime += Time.deltaTime;
            if (stayTime > maxStayTime)
            {
                movingPlatform.PositionMoveTo(PositionID + 1);
                stayTime = 0;
            }
        }
    }
}
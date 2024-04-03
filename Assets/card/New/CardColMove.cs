using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardColMove : MonoBehaviour
{
    public GameObject card;
    public Vector3 CardPos;

    public GameObject col;
    public Vector3 CardCol;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {

        CardPos = card.gameObject.transform.position;

        CardCol = col.gameObject.transform.position;

        col.gameObject.transform.position = CardPos;
    }
}

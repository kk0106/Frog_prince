using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxAttackButton : MonoBehaviour
{

    [Header("ax")] 
    public GameObject ax;
    private Rigidbody rb;
    public float speed;
    private Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        ax.SetActive(false);
        rb = ax.GetComponent<Rigidbody>();
        ani = ax.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(ax.activeInHierarchy)
        {
           rb.velocity = Vector3.forward*speed;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            ax.SetActive (true);
        }
    }
}

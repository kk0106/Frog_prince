using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstTipTrigger : MonoBehaviour
{
    public GameObject tip;
    public Animator ani;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        tip.SetActive(false);

        ani=tip.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (tip)
        {
            time += Time.deltaTime;
        }
        if (time > 0.5)
        {
            ani.SetBool("run", true);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Player")
        {
            tip.SetActive(true);
        }
    }
}

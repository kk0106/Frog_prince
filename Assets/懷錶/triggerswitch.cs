using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerswitch : MonoBehaviour
{
    public GameObject monster;
    public GameObject monster2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {// Activate the monsters and deactivate this trigger object
            monster.SetActive(false);
            monster2.SetActive(true);
            gameObject.SetActive(false);
            hammerbro thrower = monster.GetComponent<hammerbro>();
            if (thrower != null)
            {
                thrower.SetThrowingEnabled(false);
            }
        }
    }
}

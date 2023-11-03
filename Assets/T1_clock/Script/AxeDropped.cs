using System.Collections;
using UnityEngine;

public class AxeDropped : MonoBehaviour
{
    public GameObject A;
    public GameObject goddess;
    public GameObject goddess2;
    public GameObject goddess3;

    void Start()
    {
        // You should use FindObjectsOfType to find all instances of the MovingPlatform script.
        // You need to store these in an array to loop through them later.
        // Now, you have the objects with the MovingPlatform script in the `objectsWithMyScript` array.
    }

    void Update()
    {
        if (!A.activeInHierarchy)
        {
            goddess.SetActive(true);

            StartCoroutine(ActivateGoddess2AfterDelay());
        }
    }

    IEnumerator ActivateGoddess2AfterDelay()
    {
        yield return new WaitForSeconds(2f);

        goddess2.SetActive(true);

        StartCoroutine(ActivateGoddess3AfterDelay());
        // You can't use the `foreach` loop here; you should use a `for` loop.
        // And you should set the `trigger` variable of each MovingPlatform.
    }
    IEnumerator ActivateGoddess3AfterDelay()
    {
        yield return new WaitForSeconds(2f);

        goddess3.SetActive(true);

        StartCoroutine(ActivateGoddess3AfterDelay());
        // You can't use the `foreach` loop here; you should use a `for` loop.
        // And you should set the `trigger` variable of each MovingPlatform.
    }
}

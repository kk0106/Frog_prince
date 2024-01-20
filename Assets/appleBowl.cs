using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class appleBowl : MonoBehaviour
{
    public GameObject applebowl;
    private BreakableObject breakableObject;
    // Start is called before the first frame update
    void Start()
    {
        breakableObject = applebowl.GetComponent<BreakableObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!applebowl.activeInHierarchy)
        {
            StartCoroutine(ReactivateAppleBowlAfterDelay(0.8f));
        }
    }

    private IEnumerator ReactivateAppleBowlAfterDelay(float delay)
    {
        // Wait for the specified delay
        yield return new WaitForSeconds(delay);

        // Reset the breakable object's health and reactivate the apple bowl
        if (breakableObject != null)
        {
            breakableObject.currentHealth = 5f;
            applebowl.SetActive(true);
        }
    }
}

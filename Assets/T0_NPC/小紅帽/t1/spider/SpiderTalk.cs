using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderTalk : MonoBehaviour
{

    public GameObject cam;
    public GameObject talk;
    // Start is called before the first frame update
    void Start()
    {
        cam.SetActive(false);
        talk.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
          

            cam.SetActive(true);

            talk.SetActive(true);
            StartCoroutine(ReactivateAppleBowlAfterDelay(5f));
        }
    }

    private IEnumerator ReactivateAppleBowlAfterDelay(float delay)
    {

        yield return new WaitForSeconds(delay); 
        cam.SetActive(false);
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stupidplatformcontroller : MonoBehaviour
{

    public GameObject form1;
    public GameObject form2;
    public GameObject form3;
    public GameObject form4;
    public GameObject form5;
    public GameObject form6;
    public GameObject form7;
    public GameObject form8;
    public GameObject form9;
    public GameObject form10;
    public int waitforsecs;

   private Animator ani1;
    private Animator ani2;
    private Animator ani3;
    private Animator ani4;
    private Animator ani5;
    private Animator ani6;
    private Animator ani7;
    private Animator ani8;    
    private Animator ani9;    
    private Animator ani10;    
       

    void Start()
    {
        ani1 = form1.GetComponent<Animator>();
        ani2 = form2.GetComponent<Animator>();
        ani3 = form3.GetComponent<Animator>();
        ani4 = form4.GetComponent<Animator>();
        ani5 = form5.GetComponent<Animator>();
        ani6 = form6.GetComponent<Animator>();
        ani7 = form7.GetComponent<Animator>();
        ani8 = form8.GetComponent<Animator>();
        ani9 = form9.GetComponent<Animator>();
        ani10 = form10.GetComponent<Animator>();
        form1.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        //A starts
        if (form1.activeInHierarchy)
        {
        form2.SetActive(true);
        form3.SetActive(true);
        form4.SetActive(true);
        StartCoroutine(BFunction());
        }
    }


IEnumerator BFunction()
{
    // Wait for the specified duration
    yield return new WaitForSeconds(waitforsecs);
    ani1.SetTrigger("close");
    ani2.SetTrigger("close");
    ani3.SetTrigger("close");
    ani4.SetTrigger("close");
    // Call the next function or perform any other action here
    form5.SetActive(true);
    form6.SetActive(true);
    form7.SetActive(true);
    StartCoroutine(CFunction());
}
IEnumerator CFunction()
{
 yield return new WaitForSeconds(waitforsecs);
    ani5.SetTrigger("close");
    ani6.SetTrigger("close");
    ani7.SetTrigger("close");
    form8.SetActive(true);
    form9.SetActive(true);
    form10.SetActive(true);
    StartCoroutine(AFunction());

}

IEnumerator AFunction()
{
yield return new WaitForSeconds(waitforsecs);
    ani8.SetTrigger("close");
    ani9.SetTrigger("close");
    ani10.SetTrigger("close");
     form1.SetActive(true);
    
}

public void Close()
{
    gameObject.SetActive(!gameObject.activeSelf);
    
}
}
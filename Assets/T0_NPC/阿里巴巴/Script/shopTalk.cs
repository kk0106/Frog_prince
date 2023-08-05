using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Flower;

public class shopTalk : MonoBehaviour
{
    FlowerSystem fs;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            fs.Next();
        }
       
       
    }
    private void OnCollisionEnter(Collision other)
    {
        other.gameObject.tag = "Player";


        fs = FlowerManager.Instance.CreateFlowerSystem("defalut", false);
        fs.SetupDialog();
        fs.ReadTextFromResource("shop");
    }
    private void OnCollisionExit(Collision other)
    {
        other.gameObject.tag = "Player";


        fs.RemoveDialog();
    }

}

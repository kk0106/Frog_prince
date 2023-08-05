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
        fs = FlowerManager.Instance.CreateFlowerSystem("defalut", false);
        fs.SetupDialog();
        fs.ReadTextFromResource("shop");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

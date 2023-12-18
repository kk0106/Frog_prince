using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _longManager : MonoBehaviour
{
    public GameObject a;
   
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!a.activeInHierarchy)
        {
            InventoryManager.RefreshItem();
        }
    }
}

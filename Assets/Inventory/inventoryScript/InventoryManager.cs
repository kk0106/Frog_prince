using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class InventoryManager : MonoBehaviour
{
    static InventoryManager instance;

    public Inventory BackPack;
    public GameObject slotGrid;
    public slot slotPrefab;
    public TMP_Text itemInformation;

    private void OnEnable()
    {
        instance.itemInformation.text = "";
    }
    
    public static void UpdateItemInfo(string itemDescription)
    {
        instance.itemInformation.text = itemDescription;
    }

    void Awake()
    {
        if (instance != null)
            Destroy(this);
        instance= this;
    }

    public static void CreateNewItem(item item)
    {
        slot newItem = Instantiate(instance.slotPrefab,instance.slotGrid.transform.position,Quaternion.identity);
        newItem.gameObject.transform.SetParent(instance.slotGrid.transform);
        newItem.slotItem = item;
        newItem.slotImage.sprite = item.itemImage;
       
    }
}

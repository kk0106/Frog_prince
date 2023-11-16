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

    public static bool HasItem(string itemID)
    {
        // Check if the inventory contains an item with the specified itemID
        return instance.BackPack.HasItem(itemID);
    }

    public static void CreateNewItem(item item)
    {
        slot newItem = Instantiate(instance.slotPrefab,instance.slotGrid.transform.position,Quaternion.identity);
        newItem.gameObject.transform.SetParent(instance.slotGrid.transform);
        newItem.slotItem = item;
        newItem.slotImage.sprite = item.itemImage;
       
    }
    public static void RemoveItem(string itemID)
    {
        // Check if the inventory contains an item with the specified itemID
        if (instance.BackPack.HasItem(itemID))
        {
            // Remove the item from the inventory
            item removedItem = instance.BackPack.RemoveItem(itemID);

            // Add any additional logic you need (e.g., update UI, play sound, etc.)

           // Debug.Log("Removed item: " + removedItem.itemName);
        }
        else
        {
           // Debug.LogWarning("Item with ID " + itemID + " not found in the inventory.");
        }
    }
}

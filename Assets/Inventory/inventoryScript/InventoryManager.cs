using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.EventSystems;

public class InventoryManager : MonoBehaviour
{
    static InventoryManager instance;
    public int slotID;
    public Inventory BackPack;
    public GameObject slotGrid;
    public GameObject emptySlot;
    public TMP_Text itemInformation;

    public List<GameObject> slots = new List<GameObject>();

   

    private void OnEnable()
    {
        instance.itemInformation.text = "";
        RefreshItem();
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

    /*public static void CreateNewItem(item item)
    {
        slot newItem = Instantiate(instance.slotPrefab,instance.slotGrid.transform.position,Quaternion.identity);
        newItem.gameObject.transform.SetParent(instance.slotGrid.transform);
        newItem.slotItem = item;
        newItem.slotImage.sprite = item.itemImage;
       
    }*/
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

    public static void RefreshItem()
    {
        for(int i = 0;i < instance.slotGrid.transform.childCount; i++)
        {
            if (instance.slotGrid.transform.childCount == 0)
                break;
            Destroy(instance.slotGrid.transform.GetChild(i).gameObject);
            instance.slots.Clear();
        }
        for (int i = 0; i < instance.BackPack.itemList.Count; i++)
        {
            // Instantiate the empty slot prefab
            GameObject emptySlotGameObject = Instantiate(instance.emptySlot);

            // Access the slot component of the instantiated object
            slot emptySlotComponent = emptySlotGameObject.GetComponent<slot>();

            // Add the empty slot game object to the slots list
            instance.slots.Add(emptySlotGameObject);

            // Set the slot ID and setup the slot with item information
            emptySlotComponent.slotID = i;
            emptySlotComponent.SetupSlot(instance.BackPack.itemList[i]);
        }
    }
}

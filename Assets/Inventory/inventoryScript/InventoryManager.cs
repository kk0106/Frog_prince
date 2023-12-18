using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.EventSystems;
using System.Diagnostics;

public class InventoryManager : MonoBehaviour
{
    static InventoryManager instance;
    public int slotID;
    public Inventory BackPack;
    public GameObject slotGrid;
    public GameObject slotPos0;
    public GameObject slotPos1;
    public GameObject slotPos2;
    public GameObject slotPos3;
    public GameObject slotPos4;
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
    UnityEngine.Debug.Log($"Checking if item {itemID} is present.");

    // Check if the instance and BackPack are not null
    if (instance != null && instance.BackPack != null)
    {
        // Call the HasItem method of the BackPack
        bool result = instance.BackPack.HasItem(itemID);

        // Log whether the item is present or not
        UnityEngine.Debug.Log($"Item {itemID} is {(result ? "present" : "not present")}");

        // Return the result of the HasItem method
        return result;
    }

    // Log a message if the instance or backpack is null
    UnityEngine.Debug.Log("Instance or backpack is null.");

    // Return false if the instance or backpack is null
    return false;
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
            // Find the index of the item with the specified itemID
            int index = instance.BackPack.GetItemIndex(itemID);

            if (index != -1)
            {
                // Clear the slot at the found index
                instance.BackPack.itemList[index] = null;

                // Rearrange the items to remove empty gaps
                RearrangeItems(instance.BackPack);
            }
        }
        else
        {
            // Debug.LogWarning("Item with ID " + itemID + " not found in the inventory.");
        }
    }


    private static void ClearItemSlot(int index)
    {
        // Check if the index is valid
        if (index >= 0 && index < instance.slots.Count)
        {
            // Clear the item slot
            instance.slots[index].GetComponent<slot>().SetupSlot(null);
        }
    }

    private static void RearrangeItems(Inventory inventory)
    {
        // Create a new list to hold the rearranged items without nulls
        List<item> rearrangedItems = new List<item>();

        // Add non-null items to the new list
        rearrangedItems.AddRange(inventory.itemList.Where(item => item != null));

        // Clear the original list
        inventory.itemList.Clear();

        // Calculate the number of empty slots needed to fill the remaining space
        int emptySlots = 5 - rearrangedItems.Count;

        // Add the rearranged items back to the original list
        inventory.itemList.AddRange(rearrangedItems);

        // Add empty slots to ensure there are always 5 slots
        for (int i = 0; i < emptySlots; i++)
        {
            inventory.itemList.Add(null);
        }
    }


    public static void RefreshItem()
{
    // Clear the list of slots before creating new ones
    instance.slots.Clear();

    // Define an array of slot positions
    GameObject[] slotPositions = { instance.slotPos0, instance.slotPos1, instance.slotPos2, instance.slotPos3, instance.slotPos4 };
    
    foreach (var slotPos in slotPositions)
    {
        foreach (Transform child in slotPos.transform)
        {
            Destroy(child.gameObject);
        }
    }

    for (int i = 0; i < instance.BackPack.itemList.Count; i++)
    {
        // Instantiate the empty slot prefab
        GameObject emptySlotGameObject = Instantiate(instance.emptySlot);

        // Set the parent to the corresponding slot position based on the index
        if (i < slotPositions.Length)
        {
            // Set the position to the position of the slotPos GameObject
            emptySlotGameObject.transform.position = slotPositions[i].transform.position;

            // Set the parent to the slotPos GameObject
            emptySlotGameObject.transform.SetParent(slotPositions[i].transform);
        }

        // Add the empty slot game object to the slots list
        instance.slots.Add(emptySlotGameObject);

        // Access the slot component of the instantiated object
        slot emptySlotComponent = emptySlotGameObject.GetComponent<slot>();

        // Set the slot ID and setup the slot with item information
        emptySlotComponent.slotID = i;
        emptySlotComponent.SetupSlot(instance.BackPack.itemList[i]);
    }
}

}

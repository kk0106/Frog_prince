using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "New Inventory",menuName =  "Inventory/New Inventory")]
public class Inventory : ScriptableObject
{
    public List<item> itemList = new List<item> ();

    public bool HasItem(string itemID)
    {
        return itemList.Any(item => itemID == itemID);
    }

    public item RemoveItem(string itemID)
    {
        // Find the index of the item with the specified itemID
        int index = itemList.FindIndex(item => itemID == item.itemID);

        if (index != -1)
        {
            // Retrieve the item at the specified index
            item removedItem = itemList[index];

            // Set the item at the specified index to null (clear the slot)
            itemList[index] = null;

            return removedItem;
        }
        else
        {
            // If the item with the specified itemID is not found, return null
            return null;
        }
    }
    public int GetItemIndex(string itemID)
    {
        // Find the index of the item with the specified itemID
        return itemList.FindIndex(item => itemID == item.itemID);
    }
}

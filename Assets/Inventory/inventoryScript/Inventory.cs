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
        int index = itemList.FindIndex(item => itemID == itemID);

        if (index != -1)
        {
            // Remove the item from the list and return it
            item removedItem = itemList[index];
            itemList.RemoveAt(index);
            return removedItem;
        }
        else
        {
            // If the item with the specified itemID is not found, return null
            return null;
        }
    }
}

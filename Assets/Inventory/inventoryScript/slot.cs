using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class slot : MonoBehaviour
{
    public int slotID;
    public item slotItem;
    public Image slotImage;
    public string slotInfo;
    public string ItemID;

    public GameObject ItemInSlot;
  
    public void ItemOnSelected()
    {
        InventoryManager.UpdateItemInfo(slotInfo);
    }


    public void SetupSlot(item item)
    {
        if(item == null)
        {
            ItemInSlot.SetActive(false);
            return;
        }

        slotImage.sprite = item.itemImage;
        slotInfo = item.itemInfo;
        ItemID = item.itemID;
    }
}

using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

[CreateAssetMenu(fileName = "New Inventory",menuName =  "Inventory/New Inventory")]
public class Inventory : ScriptableObject
{
    public List<item> itemList = new List<item> ();
}

using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class BreakableObject : MonoBehaviour
{
    //private Animator _animator;
    public float maxHealth = 100f;
    private float currentHealth;

    public bool Item;
    public List<item> thisItems = new List<item>();
    public Inventory playerInventory;
    // Add any additional variables and references as needed

    void Start()
    {

        //_animator = GetComponent<Animator>();
        currentHealth = maxHealth;
    }

    // Apply damage to the breakable object
    public void ApplyDamage(float damageAmount)
    {
        currentHealth -= damageAmount;

        if (currentHealth <= 0f)
        {
            Break();
        }
    }

    // Implement breaking behavior here
    private void Break()
    {
        this.gameObject.SetActive(false);

        if (Item && playerInventory != null)
        {
            if (playerInventory.itemList == null)
            {
                playerInventory.itemList = new List<item>();
            }

            // Iterate through thisItems and add each item to the inventory
            foreach (item newItem in thisItems)
            {
                playerInventory.itemList.Add(newItem);
                InventoryManager.CreateNewItem(newItem);
            }
        }
    }
}
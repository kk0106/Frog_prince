using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using UnityEngine;

public class BreakableObject : MonoBehaviour
{
    //private Animator _animator;
    public float maxHealth = 100f;
    public float currentHealth;

    public bool IsItem;
    public item thisItem;
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
        
        if (IsItem == true)
        {
            for (int i = 0; i < playerInventory.itemList.Count; i++)
            {
                if (playerInventory.itemList[i] = thisItem)
                {
                     return;
                    if (playerInventory.itemList[i] == null)
                    {
                    playerInventory.itemList[i] = thisItem;
                    InventoryManager.RefreshItem();
                    break;
                    }
                }
            }
        }
        
    }
    

    public float GetCurrentHealth()
    {
        return currentHealth;
    }
}
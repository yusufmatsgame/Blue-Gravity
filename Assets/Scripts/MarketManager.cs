using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MarketManager : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {


        if (InventoryManager.Instance.inventoryLists[0][InventoryManager.Instance.FindItemInInventory(InventoryLocation.player, 10008)].itemQuantity > 5 && Input.GetKeyDown(KeyCode.Z))
        {
            for (int i = 0; i < 5; i++)
            {
                InventoryManager.Instance.RemoveItem(InventoryLocation.player, 10008);
            }

            InventoryManager.Instance.AddItem(InventoryLocation.player, 10001);
        }


    }

    public void buyItem(int code)
    {
        if (InventoryManager.Instance.inventoryLists[0][InventoryManager.Instance.FindItemInInventory(InventoryLocation.player, 10008)].itemQuantity > 5)
        {
            for (int i = 0; i < 5; i++)
            {
                InventoryManager.Instance.RemoveItem(InventoryLocation.player, 10008);
            }

            InventoryManager.Instance.AddItem(InventoryLocation.player, code);
        }
    }
}

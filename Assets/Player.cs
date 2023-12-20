using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Inventory inventory;

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        if (data != null)
        {
            Vector3 position = new Vector3(data.position[0], data.position[1], data.position[2]);
            transform.position = position;

            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (!string.IsNullOrEmpty(data.itemNames[i]))
                {
                    GameObject itemPrefab = Resources.Load<GameObject>(data.itemNames[i]);
                    string itemName = data.itemNames[i];

                    if (itemPrefab != null)
                    {
                        inventory.isFull[i] = true;
                        inventory.item[i] = itemPrefab;
                        Instantiate(itemPrefab, inventory.slots[i].transform, false);
                        GameObject itemToDestroy = GameObject.FindWithTag(itemName);

                        // If the GameObject is found, destroy it
                        if (itemToDestroy != null)
                        {
                            Destroy(itemToDestroy);
                            Debug.Log($"Destroyed item: {itemName}");
                        }
                        else
                        {
                            Debug.LogWarning($"Item with tag {itemName} not found.");
                        }
                    }
                    else
                    {
                        Debug.LogWarning($"Item with name {data.itemNames[i]} not found.");
                    }
                }
            }
        }
    }

}

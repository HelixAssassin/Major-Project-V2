using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Pickup : MonoBehaviour
{
    private Inventory inventory;
    public GameObject itemButton;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    void OnTriggerEnter(Collider other) {
        
        if (other.CompareTag("Player")) {
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false) {
                    inventory.isFull[i] = true;
                    inventory.slots[i].SetActive(true); 
                    Instantiate(itemButton, inventory.slots[i].transform);
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}
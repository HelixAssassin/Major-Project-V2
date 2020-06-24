using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowButton : MonoBehaviour
{
    private Inventory inventory;
    public Button arrowButton;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    private void Update()
    {
        inventory.enabled = true; 
        arrowButton.interactable = true;
    }

    private void FixedUpdate()
    {
        inventory.enabled = false;
        arrowButton.interactable = false;
    }
}
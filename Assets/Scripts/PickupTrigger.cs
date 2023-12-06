using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupTrigger : MonoBehaviour
{
    [Header("Visual Cue")]
    [SerializeField] private GameObject visualCue;
    [SerializeField] private MyPickup pickup;

    private bool playerInRange;

    private void Awake() 
    {
        playerInRange = false;
        visualCue.SetActive(false);
    }

    private void Update() 
    {
        if (playerInRange) 
        {
            visualCue.SetActive(true);
            if (PlayerController.GetInstance().GetInteractPressed()) 
            {
                pickup.PutItInInventory();
            }
        }
        else 
        {
            visualCue.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider collider) 
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit(Collider collider) 
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = false;
        }
    }
}
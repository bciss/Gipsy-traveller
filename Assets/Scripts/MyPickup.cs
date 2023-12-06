using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PowerGridInventory;

[RequireComponent(typeof(PGISlotItem))]
public class MyPickup : MonoBehaviour
{
    public  PGIModel DefaultInventory;
    private  PGISlotItem Item;
 
    void Awake()
    {
        Item = GetComponent<PGISlotItem>();
    }

    public void PutItInInventory()
    {
        if(DefaultInventory != null && Item != null)
            DefaultInventory.Pickup(Item);
    }
}

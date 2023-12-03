using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PowerGridInventory;

public class MyItemFilter : MonoBehaviour
{

    public  List<ItemType> AllowedTypes;

    public void IsTypeValid(PGISlotItem item, PGIModel model, PGISlot slot)
    {
        if (AllowedTypes != null && AllowedTypes.Count > 0)
        {
            var type = item.GetComponent<MyItemType>();
            if (type != null && AllowedTypes.Contains(type.itemType))
            {
                return;
            }
            model.CanPerformAction = false;
        }
    }
}

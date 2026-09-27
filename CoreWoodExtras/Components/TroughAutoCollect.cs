using System.Collections.Generic;
using UnityEngine;

namespace CoreWoodExtras.Containers;

public class TroughAutoCollect : MonoBehaviour
{
    private const float CheckInterval = 2f;

    private Container m_container;

    private void Awake()
    {
        m_container = GetComponent<Container>();
        if (m_container == null)
        {
            Jotunn.Logger.LogWarning($"TroughAutoCollect on '{gameObject.name}' could not find a Container component.");
            return;
        }
        InvokeRepeating(nameof(CollectNearbyItems), CheckInterval, CheckInterval);
    }

    private void CollectNearbyItems()
    {
        if (!MainConfig.TroughAutoCollectEnabled.Value)
        {
            return;
        }
        if (m_container == null || m_container.m_nview == null || !m_container.m_nview.IsValid() || !m_container.IsOwner() || UtilityMethods.IsInUse(m_container))
        {
            return;
        }
        if (!RestrictContainers.IsRestrictedContainer(m_container.m_name, out HashSet<string> allowedItems))
        {
            return;
        }

        float range = MainConfig.ContainerRange.Value;
        Collider[] colliders = Physics.OverlapSphere(transform.position, range, LayerMask.GetMask("item"));
        HashSet<ItemDrop> seen = new HashSet<ItemDrop>();
        foreach (Collider collider in colliders)
        {
            ItemDrop itemDrop = collider.GetComponentInParent<ItemDrop>();
            if (itemDrop == null || !seen.Add(itemDrop) || itemDrop.m_nview == null || !itemDrop.m_nview.IsValid())
            {
                continue;
            }
            if (!allowedItems.Contains(itemDrop.m_itemData.PrefabName()))
            {
                continue;
            }
            if (!itemDrop.m_nview.IsOwner())
            {
                itemDrop.RequestOwn();
                continue;
            }
            if (!itemDrop.CanPickup())
            {
                continue;
            }
            CollectItem(itemDrop);
        }
    }

    private void CollectItem(ItemDrop itemDrop)
    {
        int stored = StoreInTrough(itemDrop.m_itemData);
        if (stored <= 0)
        {
            return;
        }
        m_container.Save();
        if (stored >= itemDrop.m_itemData.m_stack)
        {
            ZNetScene.instance.Destroy(itemDrop.gameObject);
        }
        else
        {
            itemDrop.m_itemData.m_stack -= stored;
            itemDrop.Save();
        }
    }

    private int StoreInTrough(ItemDrop.ItemData item)
    {
        Inventory inventory = m_container.GetInventory();
        string sharedName = item.m_shared.m_name;
        int before = inventory.CountItems(sharedName);
        ItemDrop.ItemData data = item.Clone();
        if (!inventory.HaveEmptySlot())
        {
            int room = inventory.FindFreeStackSpace(sharedName, data.m_worldLevel);
            if (room <= 0)
            {
                return 0;
            }
            data.m_stack = Mathf.Min(data.m_stack, room);
        }
        if (!inventory.AddItem(data))
        {
            return 0;
        }
        return inventory.CountItems(sharedName) - before;
    }
}

using System.Collections.Generic;
using UnityEngine;

namespace CoreWoodExtras.Containers;

// Sweeps the trough's own Auto-Feed range for dropped items it accepts (troughItems in AddDecor) and pulls them
// straight into its inventory, so food left on the ground still ends up feeding the animals.
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
        // Every client that has the trough loaded runs this, so only its owner collects. Claiming it here would make the
        // clients take it from each other every check, and take it from a player who has it open.
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
                // Only the owner may despawn the dropped item. Ask its owner for it, the same way a player picking it up
                // does (with the vanilla back-off), and pick it up on a later check.
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

    // Mirrors SeedBed's StoreInContainer: counting before/after keeps this right when only part of the stack fits.
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

using System.Collections;
using Jotunn.Utils;
using UnityEngine;

namespace CoreWoodExtras.Containers;

public class TroughVisualState : MonoBehaviour
{
    private const float CheckInterval = 2f;
    private const string EnabledChildName = "Enabled";

    private Container m_container;
    private Transform m_enabledChild;
    private Coroutine m_checkRoutine;

    private void Awake()
    {
        m_container = GetComponent<Container>();
        m_enabledChild = Utils.FindChild(transform, EnabledChildName);

        if (m_container == null)
        {
            Jotunn.Logger.LogWarning($"TroughVisualState on '{gameObject.name}' could not find a Container component.");
        }

        if (m_enabledChild == null)
        {
            Jotunn.Logger.LogWarning($"TroughVisualState on '{gameObject.name}' could not find child '{EnabledChildName}'.");
        }
    }

    private void OnEnable()
    {
        m_checkRoutine = StartCoroutine(CheckInventoryLoop());
    }

    private void OnDisable()
    {
        if (m_checkRoutine != null)
        {
            StopCoroutine(m_checkRoutine);
            m_checkRoutine = null;
        }
    }

    private IEnumerator CheckInventoryLoop()
    {
        while (true)
        {
            UpdateVisualState();
            yield return new WaitForSeconds(CheckInterval);
        }
    }

    private void UpdateVisualState()
    {
        if (m_container == null || m_enabledChild == null)
        {
            return;
        }

        Inventory inventory = m_container.GetInventory();
        bool isEmpty = inventory == null || inventory.NrOfItems() == 0;

        m_enabledChild.gameObject.SetActive(!isEmpty);
    }
}
using System;
using System.Collections.Generic;
using UnityEngine;

namespace CoreWoodExtras.Containers;

public class VisualStack : MonoBehaviour
{
	public List<Transform> stackMeshes = new List<Transform>();

	private Container container;

	private Inventory inventory;

	public void Start()
	{
		container = GetComponentInParent<Container>();
		if ((bool)container)
		{
			inventory = container.GetInventory();
		}
		if (inventory != null)
		{
			Inventory obj = inventory;
			obj.m_onChanged = (Action)Delegate.Combine(obj.m_onChanged, new Action(UpdateVisuals));
			UpdateVisuals();
		}
	}

	public void UpdateVisuals()
	{
		SetVisualsActive(inventory.SlotsUsedPercentage());
	}

	public void SetVisualsActive(float fillPercentage)
	{
		float num = Mathf.Ceil(fillPercentage / 100f * (float)stackMeshes.Count);
		for (int i = 0; i < stackMeshes.Count; i++)
		{
			bool active = i == 0 || (float)i < num;
			stackMeshes[i].gameObject.SetActive(active);
		}
	}
}

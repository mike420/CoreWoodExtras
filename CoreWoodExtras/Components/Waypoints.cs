using UnityEngine;

public class Waypoints : MonoBehaviour
{
	[Range(0f, 2f)]
	[SerializeField]
	private float gizmoSize = 1f;

	[SerializeField]
	private bool canLoop = true;

	private void OnDrawGizmos()
	{
		foreach (Transform item in base.transform)
		{
			Gizmos.color = Color.blue;
			Gizmos.DrawWireSphere(item.position, gizmoSize);
		}
		Gizmos.color = Color.red;
		for (int i = 0; i < base.transform.childCount - 1; i++)
		{
			Gizmos.DrawLine(base.transform.GetChild(i).position, base.transform.GetChild(i + 1).position);
		}
		if (canLoop)
		{
			Gizmos.DrawLine(base.transform.GetChild(base.transform.childCount - 1).position, base.transform.GetChild(0).position);
		}
	}

	public Transform GetNextWaypoint(Transform currentWaypoint)
	{
		if (currentWaypoint == null)
		{
			return base.transform.GetChild(0);
		}
		if (currentWaypoint.GetSiblingIndex() < base.transform.childCount - 1)
		{
			return base.transform.GetChild(currentWaypoint.GetSiblingIndex() + 1);
		}
		if (canLoop)
		{
			return base.transform.GetChild(0);
		}
		return base.transform.GetChild(currentWaypoint.GetSiblingIndex());
	}
}

using UnityEngine;

public class WaypointMover : MonoBehaviour
{
	[SerializeField]
	private Waypoints waypoints = null;

	[Range(0f, 10f)]
	[SerializeField]
	private float moveSpeed = 5f;

	[Range(0f, 20f)]
	[SerializeField]
	private float rotateSpeed = 0.5f;

	[SerializeField]
	private float distanceThreshold = 0.1f;

	private Transform currentWaypoint;

	private Quaternion rotationGoal;

	private Vector3 directionToWaypoint;

	private void Start()
	{
		currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
		base.transform.position = currentWaypoint.position;
		currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
		base.transform.LookAt(currentWaypoint);
	}

	private void Update()
	{
		base.transform.position = Vector3.MoveTowards(base.transform.position, currentWaypoint.position, moveSpeed * Time.deltaTime);
		if (Vector3.Distance(base.transform.position, currentWaypoint.position) < distanceThreshold)
		{
			currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
		}
		RotateTowardsWaypoint();
	}

	private void RotateTowardsWaypoint()
	{
		directionToWaypoint = (currentWaypoint.position - base.transform.position).normalized;
		rotationGoal = Quaternion.LookRotation(directionToWaypoint);
		base.transform.rotation = Quaternion.Slerp(base.transform.rotation, rotationGoal, rotateSpeed * Time.deltaTime);
	}
}

using UnityEngine;

public class ParentPlatform : MonoBehaviour
{
	private Piece m_piece;

	private void Start()
	{
		m_piece = base.gameObject.GetComponentInParent<Piece>();
	}

	private void OnCollisionEnter(Collision other)
	{
		other.transform.SetParent(base.transform);
		other.gameObject.GetComponent<Rigidbody>().interpolation = RigidbodyInterpolation.None;
		m_piece.m_canBeRemoved = false;
	}

	private void OnCollisionExit(Collision other)
	{
		other.transform.SetParent(null);
		other.gameObject.GetComponent<Rigidbody>().interpolation = RigidbodyInterpolation.Interpolate;
		m_piece.m_canBeRemoved = true;
	}
}

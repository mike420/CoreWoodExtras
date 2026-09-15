using UnityEngine;

public class Elevator : MonoBehaviour
{
	public bool m_canMove = true;

	public float m_speed = 2f;

	public int m_startPoint;

	public Transform[] m_points;

	private int i;

	private bool m_reverse;

	public static readonly int m_elevatorPosition = "elevatorPosition".GetStableHashCode();

	private string m_name;

	private ZNetView m_nview;

	public void Start()
	{
		m_name = base.gameObject.GetComponentInParent<Piece>().name;
		m_nview = base.gameObject.GetComponentInParent<ZNetView>();
		if (m_nview != null && m_nview.GetZDO() != null)
		{
			i = m_nview.GetZDO().GetInt(m_elevatorPosition);
			base.transform.position = m_points[i].position;
		}
		else
		{
			base.transform.position = m_points[m_startPoint].position;
			i = m_startPoint;
		}
	}

	public void Update()
	{
		if (Vector3.Distance(base.transform.position, m_points[i].position) < 0.01f)
		{
			m_canMove = false;
			if (i == m_points.Length - 1)
			{
				m_reverse = true;
				i--;
				return;
			}
			if (i == 0)
			{
				m_reverse = false;
				i++;
				return;
			}
			if (m_reverse)
			{
				i--;
			}
			else
			{
				i++;
			}
		}
		if (m_canMove)
		{
			base.transform.position = Vector3.MoveTowards(base.transform.position, m_points[i].position, m_speed * Time.deltaTime);
			m_nview.GetZDO().Set(m_elevatorPosition, i);
		}
	}
}

using UnityEngine;

public class ElevatorSwitch : MonoBehaviour, Hoverable, Interactable
{
	public Elevator m_elevator;

	public EffectList m_elevatorSFX;

	public float m_hoverOffset;

	private string m_name;

	private Piece m_piece;

	private void Start()
	{
		m_piece = base.gameObject.GetComponentInParent<Piece>();
		m_name = m_piece.m_name;
		if (m_elevator != null)
		{
			m_elevator.RegisterSwitch(this);
		}
	}

	public string GetHoverText()
	{
		return Localization.instance.Localize(m_name + "\n[<color=yellow><b>$KEY_Use</b></color>] $text_use_elevator");
	}

	public string GetHoverName()
	{
		return m_name;
	}

	public bool Interact(Humanoid human, bool hold, bool alt)
	{
		if (hold || m_elevator == null)
		{
			return false;
		}
		if (m_elevator.Activate(2f, playSound: true))
		{
			PlayStartSound();
		}
		return true;
	}

	public void PlayStartSound()
	{
		m_elevatorSFX?.Create(base.transform.position, base.transform.rotation);
	}

	public bool UseItem(Humanoid user, ItemDrop.ItemData item)
	{
		return false;
	}

	public float GetHoverOffset()
	{
		return m_hoverOffset;
	}
}

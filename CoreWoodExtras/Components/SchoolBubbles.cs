using UnityEngine;

public class SchoolBubbles : MonoBehaviour
{
	public ParticleSystem _bubbleParticles;

	public float _emitEverySecond = 0.01f;

	public float _speedEmitMultiplier = 0.25f;

	public int _minBubbles;

	public int _maxBubbles = 5;

	public void Start()
	{
		if (_bubbleParticles == null)
		{
			_bubbleParticles = base.transform.GetComponent<ParticleSystem>();
		}
	}

	public void EmitBubbles(Vector3 pos, float amount)
	{
		if (!(amount * _speedEmitMultiplier < 1f))
		{
			_bubbleParticles.transform.position = pos;
			_bubbleParticles.Emit(Mathf.Clamp((int)(amount * _speedEmitMultiplier), _minBubbles, _maxBubbles));
		}
	}
}

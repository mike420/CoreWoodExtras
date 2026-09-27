using System.Collections.Generic;
using UnityEngine;

public class SchoolController : MonoBehaviour
{
	public SchoolChild[] _childPrefab;

	public bool _groupChildToNewTransform;

	public Transform _groupTransform;

	public string _groupName = "";

	public bool _groupChildToSchool;

	public int _childAmount = 250;

	public float _spawnSphere = 3f;

	public float _spawnSphereDepth = 3f;

	public float _spawnSphereHeight = 1.5f;

	public float _childSpeedMultipler = 2f;

	public float _minSpeed = 6f;

	public float _maxSpeed = 10f;

	public AnimationCurve _speedCurveMultiplier = new AnimationCurve(new Keyframe(0f, 1f), new Keyframe(1f, 1f));

	public float _minScale = 0.7f;

	public float _maxScale = 1f;

	public float _minDamping = 1f;

	public float _maxDamping = 2f;

	public float _waypointDistance = 1f;

	public float _minAnimationSpeed = 2f;

	public float _maxAnimationSpeed = 4f;

	public float _randomPositionTimerMax = 10f;

	public float _randomPositionTimerMin = 4f;

	public float _acceleration = 0.025f;

	public float _brake = 0.01f;

	public float _positionSphere = 25f;

	public float _positionSphereDepth = 5f;

	public float _positionSphereHeight = 5f;

	public bool _childTriggerPos;

	public bool _forceChildWaypoints;

	public bool _autoRandomPosition;

	public float _forcedRandomDelay = 1.5f;

	public float _schoolSpeed;

	public List<SchoolChild> _roamers;

	public Vector3 _posBuffer;

	public Vector3 _posOffset;

	public bool _avoidance;

	public float _avoidAngle = 0.35f;

	public float _avoidDistance = 1f;

	public float _avoidSpeed = 75f;

	public float _stopDistance = 0.5f;

	public float _stopSpeedMultiplier = 2f;

	public LayerMask _avoidanceMask = -1;

	public bool _push;

	public float _pushDistance;

	public float _pushForce = 5f;

	public SchoolBubbles _bubbles;

	public int _updateDivisor = 1;

	public float _newDelta;

	public int _updateCounter;

	public int _activeChildren;

	public bool _useLegacyAnimations = true;

	public void Start()
	{
		_posBuffer = base.transform.position + _posOffset;
		_schoolSpeed = Random.Range(1f, _childSpeedMultipler);
		AddFish(_childAmount);
		Invoke("AutoRandomWaypointPosition", RandomWaypointTime());
	}

	public void Update()
	{
		if (_activeChildren > 0)
		{
			if (_updateDivisor > 1)
			{
				_updateCounter++;
				_updateCounter %= _updateDivisor;
				_newDelta = Time.deltaTime * (float)_updateDivisor;
			}
			else
			{
				_newDelta = Time.deltaTime;
			}
			UpdateFishAmount();
			for (int i = 0; i < _roamers.Count; i++)
			{
				if (_roamers[i] != null && _roamers[i].ShouldUpdate(_updateCounter))
				{
					_roamers[i].childUpdate();
				}
			}
		}
	}

	private bool _ownsGroupTransform;

	public void OnDestroy()
	{
		if (_roamers != null)
		{
			foreach (SchoolChild roamer in _roamers)
			{
				if (roamer != null)
				{
					Object.Destroy(roamer.gameObject);
				}
			}
			_roamers.Clear();
		}
		if (_ownsGroupTransform && _groupTransform != null)
		{
			Object.Destroy(_groupTransform.gameObject);
		}
	}

	public void InstantiateGroup()
	{
		if (!(_groupTransform != null))
		{
			GameObject gameObject = new GameObject();
			_ownsGroupTransform = true;
			_groupTransform = gameObject.transform;
			_groupTransform.position = base.transform.position;
			if (_groupName != "")
			{
				gameObject.name = _groupName;
			}
			else
			{
				gameObject.name = base.transform.name + " Fish Container";
			}
		}
	}

	public void AddFish(int amount)
	{
		if (_groupChildToNewTransform)
		{
			InstantiateGroup();
		}
		for (int i = 0; i < amount; i++)
		{
			int num = Random.Range(0, _childPrefab.Length);
			SchoolChild schoolChild = Object.Instantiate(_childPrefab[num]);
			schoolChild._spawner = this;
			_roamers.Add(schoolChild);
			AddChildToParent(schoolChild.transform);
		}
	}

	public void AddChildToParent(Transform obj)
	{
		if (_groupChildToSchool)
		{
			obj.parent = base.transform;
		}
		else if (_groupChildToNewTransform)
		{
			obj.parent = _groupTransform;
		}
	}

	public void RemoveFish(int amount)
	{
		for (int i = 0; i < amount && _roamers.Count > 0; i++)
		{
			SchoolChild schoolChild = _roamers[_roamers.Count - 1];
			_roamers.RemoveAt(_roamers.Count - 1);
			if (schoolChild != null)
			{
				Object.Destroy(schoolChild.gameObject);
			}
		}
	}

	public void UpdateFishAmount()
	{
		if (_childAmount >= 0 && _childAmount < _roamers.Count)
		{
			RemoveFish(1);
		}
		else if (_childAmount > _roamers.Count)
		{
			AddFish(1);
		}
	}

	public void SetRandomWaypointPosition()
	{
		_schoolSpeed = Random.Range(1f, _childSpeedMultipler);
		Vector3 zero = Vector3.zero;
		zero.x = Random.Range(0f - _positionSphere, _positionSphere) + base.transform.position.x;
		zero.z = Random.Range(0f - _positionSphereDepth, _positionSphereDepth) + base.transform.position.z;
		zero.y = Random.Range(0f - _positionSphereHeight, _positionSphereHeight) + base.transform.position.y;
		_posBuffer = zero;
		if (_forceChildWaypoints)
		{
			for (int i = 0; i < _roamers.Count; i++)
			{
				_roamers[i].Wander(Random.value * _forcedRandomDelay);
			}
		}
	}

	public void AutoRandomWaypointPosition()
	{
		if (_autoRandomPosition && _activeChildren > 0)
		{
			SetRandomWaypointPosition();
		}
		CancelInvoke("AutoRandomWaypointPosition");
		Invoke("AutoRandomWaypointPosition", RandomWaypointTime());
	}

	public float RandomWaypointTime()
	{
		return Random.Range(_randomPositionTimerMin, _randomPositionTimerMax);
	}

	public void OnDrawGizmos()
	{
		if (!Application.isPlaying && _posBuffer != base.transform.position + _posOffset)
		{
			_posBuffer = base.transform.position + _posOffset;
		}
		Gizmos.color = Color.blue;
		Gizmos.DrawWireCube(_posBuffer, new Vector3(_spawnSphere * 2f, _spawnSphereHeight * 2f, _spawnSphereDepth * 2f));
		Gizmos.color = Color.cyan;
		Gizmos.DrawWireCube(base.transform.position, new Vector3(_positionSphere * 2f + _spawnSphere * 2f, _positionSphereHeight * 2f + _spawnSphereHeight * 2f, _positionSphereDepth * 2f + _spawnSphereDepth * 2f));
	}
}

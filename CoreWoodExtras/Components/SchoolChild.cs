using UnityEngine;

public class SchoolChild : MonoBehaviour
{
	public SchoolController _spawner;

	private Vector3 _wayPoint;

	[HideInInspector]
	public float _speed = 10f;

	private float _stuckCounter;

	private float _damping;

	private Transform _model;

	private float _targetSpeed;

	private float tParam;

	private float _rotateCounterR;

	private float _rotateCounterL;

	public Transform _scanner;

	private bool _scan = true;

	private bool _instantiated;

	private static int _updateNextSeed;

	private int _updateSeed = -1;

	public Transform _cacheTransform;

	private Animation _legacyAnim;

	private Animator anim;

	public void Start()
	{
		_cacheTransform = base.transform;
		LocateRequiredChildren();
		if (_spawner._useLegacyAnimations)
		{
			_legacyAnim = _model.GetComponent<Animation>();
		}
		else
		{
			anim = _model.GetComponent<Animator>();
		}
		SetRandomScale();
		RandomizeStartAnimationFrame();
		_speed = Random.Range(_spawner._minSpeed, _spawner._maxSpeed);
		Wander(0f);
		SetRandomWaypoint();
		CheckForBubblesThenInvoke();
		_instantiated = true;
		GetStartPos();
		FrameSkipSeedInit();
		_spawner._activeChildren++;
	}

	// With an update divisor above 1 the school only moves each fish every few frames (with a bigger delta), and the
	// seed picks which frame is this fish's turn.
	public bool ShouldUpdate(int updateCounter)
	{
		return _instantiated && (_spawner._updateDivisor <= 1 || _updateSeed == updateCounter);
	}

	public void childUpdate()
	{
		CheckForDistanceToWaypoint();
		RotationBasedOnWaypointOrAvoidance();
		ForwardMovement();
		RayCastToPushAwayFromObstacles();
		SetAnimationSpeed();
	}

	public void FrameSkipSeedInit()
	{
		if (_spawner._updateDivisor > 1)
		{
			// Spread the fish evenly over the frames, one frame in every _updateDivisor each.
			_updateSeed = _updateNextSeed % _spawner._updateDivisor;
			_updateNextSeed = (_updateNextSeed + 1) % _spawner._updateDivisor;
		}
	}

	public void CheckForBubblesThenInvoke()
	{
		if (_spawner._bubbles != null)
		{
			InvokeRepeating("EmitBubbles", _spawner._bubbles._emitEverySecond * Random.value + 1f, _spawner._bubbles._emitEverySecond);
		}
	}

	public void EmitBubbles()
	{
		_spawner._bubbles.EmitBubbles(_cacheTransform.position, _speed);
	}

	public void OnDisable()
	{
		CancelInvoke();
		_spawner._activeChildren--;
	}

	public void OnEnable()
	{
		if (_instantiated)
		{
			CheckForBubblesThenInvoke();
			_spawner._activeChildren++;
		}
	}

	public void LocateRequiredChildren()
	{
		if (_model == null)
		{
			_model = _cacheTransform.Find("Model");
		}
		if (_scanner == null)
		{
			_scanner = new GameObject().transform;
			_scanner.parent = base.transform;
			_scanner.localRotation = Quaternion.identity;
			_scanner.localPosition = Vector3.zero;
		}
	}

	public void SkewModelForLessUniformedMovement()
	{
		Quaternion identity = Quaternion.identity;
		identity.eulerAngles = new Vector3(0f, 0f, Random.Range(-25, 25));
		_model.rotation = identity;
	}

	public void SetRandomScale()
	{
		float num = Random.Range(_spawner._minScale, _spawner._maxScale);
		_cacheTransform.localScale = Vector3.one * num;
	}

	public void RandomizeStartAnimationFrame()
	{
		if (!_spawner._useLegacyAnimations)
		{
			return;
		}
		foreach (AnimationState item in _legacyAnim)
		{
			item.time = Random.value * item.length;
		}
	}

	public void SetAnimationSpeed()
	{
		if (_spawner._useLegacyAnimations)
		{
			foreach (AnimationState item in _legacyAnim)
			{
				item.speed = Random.Range(_spawner._minAnimationSpeed, _spawner._maxAnimationSpeed) * _spawner._schoolSpeed * _speed + 0.1f;
			}
			return;
		}
		anim.speed = Random.Range(_spawner._minAnimationSpeed, _spawner._maxAnimationSpeed) * _spawner._schoolSpeed * _speed + 0.1f;
	}

	public void GetStartPos()
	{
		_cacheTransform.position = _wayPoint - new Vector3(0.1f, 0.1f, 0.1f);
	}

	public Vector3 findWaypoint()
	{
		Vector3 zero = Vector3.zero;
		zero.x = Random.Range(0f - _spawner._spawnSphere, _spawner._spawnSphere) + _spawner._posBuffer.x;
		zero.z = Random.Range(0f - _spawner._spawnSphereDepth, _spawner._spawnSphereDepth) + _spawner._posBuffer.z;
		zero.y = Random.Range(0f - _spawner._spawnSphereHeight, _spawner._spawnSphereHeight) + _spawner._posBuffer.y;
		return zero;
	}

	public void RayCastToPushAwayFromObstacles()
	{
		if (_spawner._push)
		{
			RotateScanner();
			RayCastToPushAwayFromObstaclesCheckForCollision();
		}
	}

	public void RayCastToPushAwayFromObstaclesCheckForCollision()
	{
		RaycastHit hitInfo = default(RaycastHit);
		float num = 0f;
		Vector3 forward = _scanner.forward;
		if (Physics.Raycast(_cacheTransform.position, forward, out hitInfo, _spawner._pushDistance, _spawner._avoidanceMask))
		{
			SchoolChild component = hitInfo.transform.GetComponent<SchoolChild>();
			num = (_spawner._pushDistance - hitInfo.distance) / _spawner._pushDistance;
			if (component != null)
			{
				_cacheTransform.position -= forward * _spawner._newDelta * num * _spawner._pushForce;
				return;
			}
			_speed -= 0.01f * _spawner._newDelta;
			if (_speed < 0.1f)
			{
				_speed = 0.1f;
			}
			_cacheTransform.position -= forward * _spawner._newDelta * num * _spawner._pushForce * 2f;
			_scan = false;
		}
		else
		{
			_scan = true;
		}
	}

	public void RotateScanner()
	{
		if (_scan)
		{
			_scanner.rotation = Random.rotation;
		}
		else
		{
			_scanner.Rotate(new Vector3(150f * _spawner._newDelta, 0f, 0f));
		}
	}

	public bool Avoidance()
	{
		if (!_spawner._avoidance)
		{
			return false;
		}
		RaycastHit hitInfo = default(RaycastHit);
		float num = 0f;
		Quaternion rotation = _cacheTransform.rotation;
		Vector3 eulerAngles = _cacheTransform.rotation.eulerAngles;
		Vector3 forward = _cacheTransform.forward;
		Vector3 right = _cacheTransform.right;
		if (Physics.Raycast(_cacheTransform.position, -Vector3.up + forward * 0.1f, out hitInfo, _spawner._avoidDistance, _spawner._avoidanceMask))
		{
			num = (_spawner._avoidDistance - hitInfo.distance) / _spawner._avoidDistance;
			eulerAngles.x -= _spawner._avoidSpeed * num * _spawner._newDelta * (_speed + 1f);
			rotation.eulerAngles = eulerAngles;
			_cacheTransform.rotation = rotation;
		}
		if (Physics.Raycast(_cacheTransform.position, Vector3.up + forward * 0.1f, out hitInfo, _spawner._avoidDistance, _spawner._avoidanceMask))
		{
			num = (_spawner._avoidDistance - hitInfo.distance) / _spawner._avoidDistance;
			eulerAngles.x += _spawner._avoidSpeed * num * _spawner._newDelta * (_speed + 1f);
			rotation.eulerAngles = eulerAngles;
			_cacheTransform.rotation = rotation;
		}
		if (Physics.Raycast(_cacheTransform.position, forward + right * Random.Range(-0.1f, 0.1f), out hitInfo, _spawner._stopDistance, _spawner._avoidanceMask))
		{
			num = (_spawner._stopDistance - hitInfo.distance) / _spawner._stopDistance;
			eulerAngles.y -= _spawner._avoidSpeed * num * _spawner._newDelta * (_targetSpeed + 3f);
			rotation.eulerAngles = eulerAngles;
			_cacheTransform.rotation = rotation;
			_speed -= num * _spawner._newDelta * _spawner._stopSpeedMultiplier * _speed;
			if (_speed < 0.01f)
			{
				_speed = 0.01f;
			}
			return true;
		}
		if (Physics.Raycast(_cacheTransform.position, forward + right * (_spawner._avoidAngle + _rotateCounterL), out hitInfo, _spawner._avoidDistance, _spawner._avoidanceMask))
		{
			num = (_spawner._avoidDistance - hitInfo.distance) / _spawner._avoidDistance;
			_rotateCounterL += 0.1f;
			eulerAngles.y -= _spawner._avoidSpeed * num * _spawner._newDelta * _rotateCounterL * (_speed + 1f);
			rotation.eulerAngles = eulerAngles;
			_cacheTransform.rotation = rotation;
			if (_rotateCounterL > 1.5f)
			{
				_rotateCounterL = 1.5f;
			}
			_rotateCounterR = 0f;
			return true;
		}
		if (Physics.Raycast(_cacheTransform.position, forward + right * (0f - (_spawner._avoidAngle + _rotateCounterR)), out hitInfo, _spawner._avoidDistance, _spawner._avoidanceMask))
		{
			num = (_spawner._avoidDistance - hitInfo.distance) / _spawner._avoidDistance;
			if (hitInfo.point.y < _cacheTransform.position.y)
			{
				eulerAngles.y -= _spawner._avoidSpeed * num * _spawner._newDelta * (_speed + 1f);
			}
			else
			{
				eulerAngles.x += _spawner._avoidSpeed * num * _spawner._newDelta * (_speed + 1f);
			}
			_rotateCounterR += 0.1f;
			eulerAngles.y += _spawner._avoidSpeed * num * _spawner._newDelta * _rotateCounterR * (_speed + 1f);
			rotation.eulerAngles = eulerAngles;
			_cacheTransform.rotation = rotation;
			if (_rotateCounterR > 1.5f)
			{
				_rotateCounterR = 1.5f;
			}
			_rotateCounterL = 0f;
			return true;
		}
		_rotateCounterL = 0f;
		_rotateCounterR = 0f;
		return false;
	}

	public void ForwardMovement()
	{
		_cacheTransform.position += _cacheTransform.TransformDirection(Vector3.forward) * _speed * _spawner._newDelta;
		if (tParam < 1f)
		{
			if (_speed > _targetSpeed)
			{
				tParam += _spawner._newDelta * _spawner._acceleration;
			}
			else
			{
				tParam += _spawner._newDelta * _spawner._brake;
			}
			_speed = Mathf.Lerp(_speed, _targetSpeed, tParam);
		}
	}

	public void RotationBasedOnWaypointOrAvoidance()
	{
		Quaternion identity = Quaternion.identity;
		identity = Quaternion.LookRotation(_wayPoint - _cacheTransform.position);
		if (!Avoidance())
		{
			_cacheTransform.rotation = Quaternion.Slerp(_cacheTransform.rotation, identity, _spawner._newDelta * _damping);
		}
		float x = _cacheTransform.localEulerAngles.x;
		x = ((x > 180f) ? (x - 360f) : x);
		Quaternion rotation = _cacheTransform.rotation;
		Vector3 eulerAngles = rotation.eulerAngles;
		eulerAngles.x = ClampAngle(x, -50f, 50f);
		rotation.eulerAngles = eulerAngles;
		_cacheTransform.rotation = rotation;
	}

	public void CheckForDistanceToWaypoint()
	{
		if ((_cacheTransform.position - _wayPoint).magnitude < _spawner._waypointDistance + _stuckCounter)
		{
			Wander(0f);
			_stuckCounter = 0f;
			CheckIfThisShouldTriggerNewFlockWaypoint();
		}
		else
		{
			_stuckCounter += _spawner._newDelta * (_spawner._waypointDistance * 0.25f);
		}
	}

	public void CheckIfThisShouldTriggerNewFlockWaypoint()
	{
		if (_spawner._childTriggerPos)
		{
			_spawner.SetRandomWaypointPosition();
		}
	}

	public static float ClampAngle(float angle, float min, float max)
	{
		if (angle < -360f)
		{
			angle += 360f;
		}
		if (angle > 360f)
		{
			angle -= 360f;
		}
		return Mathf.Clamp(angle, min, max);
	}

	public void Wander(float delay)
	{
		_damping = Random.Range(_spawner._minDamping, _spawner._maxDamping);
		_targetSpeed = Random.Range(_spawner._minSpeed, _spawner._maxSpeed) * _spawner._speedCurveMultiplier.Evaluate(Random.value) * _spawner._schoolSpeed;
		Invoke("SetRandomWaypoint", delay);
	}

	public void SetRandomWaypoint()
	{
		tParam = 0f;
		_wayPoint = findWaypoint();
	}
}

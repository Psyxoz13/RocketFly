using UnityEngine;

public class TraveledDistance : MonoBehaviour
{
    public float Distance { get; private set; }

    [SerializeField] private Transform _target;
    [SerializeField] private Vector3 _axis;

#if UNITY_EDITOR
    [Header("Debug")]
    [SerializeField] private float _distanceDebug;
#endif

    private Vector3 _startPoint;

    private void Awake()
    {
        if (_target == null)
        {
            _target = transform;
        }

        SetStartPoint(_target.position);
    }

    public void SetTarget(Transform target)
    {
        _target = target;
    }

    public void SetStartPoint(Vector3 startPoint)
    {
        _startPoint = GetAxisPosition(startPoint);
    }

    private void LateUpdate()
    {
        Distance = Vector3.Distance(
            _startPoint,
            GetAxisPosition(
                _target.position));

#if UNITY_EDITOR
        _distanceDebug = Distance;
#endif
    }

    private Vector3 GetAxisPosition(Vector3 position)
    {
        return new Vector3(
            position.x * _axis.x,
            position.y * _axis.y,
            position.z * _axis.z);
    }

    private void OnValidate()
    {
        _axis.x = Mathf.RoundToInt(Mathf.Clamp01(_axis.x));
        _axis.y = Mathf.RoundToInt(Mathf.Clamp01(_axis.y));
        _axis.z = Mathf.RoundToInt(Mathf.Clamp01(_axis.z));
    }
}

using UnityEngine;

[RequireComponent(typeof(ObjectPool))]
public abstract class Generator : MonoBehaviour
{
    [SerializeField] protected float _generateDistance;
    [SerializeField] protected int _backOffsetCount = 3;

    protected ObjectPool _objectPool;

    private GameObject _prevObject;

    public void Init()
    {
        _objectPool = GetComponent<ObjectPool>();

        _prevObject = Generate();

        for (int i = -_backOffsetCount; i < _objectPool.PoolCount - _backOffsetCount; i++)
        {
            var position = Vector3.forward;
            position.z = i * _generateDistance;

            SetObjectPosition(position);
        }
    }

    public void PlaceObject(float distance)
    {
        var position = Vector3.forward;
        position.z = (int)(distance / _generateDistance) * _generateDistance + (_objectPool.PoolCount - _backOffsetCount) * _generateDistance;

        if (position.z  > _prevObject.transform.position.z)
        {
            SetObjectPosition(position);
        }
    }

    private void SetObjectPosition(Vector3 position)
    {
        var generatedObject = Generate();

        float z = position.z;

        position = generatedObject.transform.position;
        position.z = z;

        generatedObject.transform.position = position;

        _prevObject = generatedObject;
    }

    protected abstract GameObject Generate();
}

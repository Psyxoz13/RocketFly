using UnityEngine;

public class ObjectPool : Pool<GameObject>
{
    public override GameObject GetObject()
    {
        var poolObject = _pool.Dequeue();

        _pool.Enqueue(poolObject);

        return poolObject;
    }

    protected override GameObject CreatePoolObject()
    {
        var poolObject = Instantiate(_object, transform);

        return poolObject;
    }
}

using System.Collections.Generic;
using UnityEngine;

public abstract class Pool<T> : MonoBehaviour
{
    public int PoolCount => _count;

    [SerializeField] protected T _object;
    [SerializeField] private int _count;

    protected Queue<T> _pool;

    private void Awake()
    {
        _pool = new Queue<T>();

        SetPool();
    }

    protected virtual void SetPool()
    {
        for (int i = 0; i < _count; i++)
        {
            var createdObject = CreatePoolObject();

            _pool.Enqueue(createdObject);
        }
    }

    protected abstract T CreatePoolObject();

    public abstract T GetObject();
}

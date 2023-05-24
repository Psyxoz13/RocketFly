using UnityEngine;

public abstract class Movement
{
    protected Rigidbody _rigidbody;
    protected MovementData _movementData;

    public Movement(Rigidbody rigidbody, MovementData movementData)
    {
        _rigidbody = rigidbody;
        _movementData = movementData;
    }

    public abstract void Move(Vector2 moveVector);
}

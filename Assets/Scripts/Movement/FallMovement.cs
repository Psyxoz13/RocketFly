using UnityEngine;

public class FallMovement : Movement
{
    public FallMovement(Rigidbody rigidbody, MovementData movementData) : base(rigidbody, movementData)
    {
        rigidbody.freezeRotation = false;
    }

    public override void Move(Vector2 moveVector)
    {
        _rigidbody.velocity = Vector3.Lerp(
            _rigidbody.velocity,
            Vector3.zero,
            Time.fixedDeltaTime * _movementData.BrakingSpeed);
    }
}

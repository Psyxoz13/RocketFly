using UnityEngine;

public class TakeoffMovement : Movement
{
    public TakeoffMovement(Rigidbody rigidbody, MovementData movementData) : base(rigidbody, movementData)
    { }

    public override void Move(Vector2 moveVector)
    {
        var targetVelocity = new Vector3()
        {
            x = moveVector.x * _movementData.AngularSpeed,
            y = (_movementData.MaxHeightWorld - _rigidbody.position.y) * _movementData.MaxRiseUpSpeed,
            z = _movementData.MoveMaxSpeed
        };

        _rigidbody.velocity =
            Vector3.Lerp(
                _rigidbody.velocity,
                targetVelocity,
                Time.fixedDeltaTime * _movementData.Acceleration);

        var targetRotation = Quaternion.LookRotation(_rigidbody.velocity.normalized, Vector3.up);
        targetRotation *= Quaternion.Euler(0f, 0f, _rigidbody.velocity.normalized.x * -90f);

        _rigidbody.MoveRotation(
            Quaternion.Lerp(
                _rigidbody.rotation,
                targetRotation,
                Time.fixedDeltaTime * _movementData.Acceleration));
    }
}

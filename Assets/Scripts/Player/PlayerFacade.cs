using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class PlayerFacade : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private MovementData _movementData;
    [SerializeField] private ParticleSystem _fireEffect;

    private Camera _camera;

    private Movement _movement;

    private float _moveXPoint;

    private void Awake()
    {
        _camera = Camera.main;

        _movement = new FallMovement(_rigidbody, _movementData);
    }

    private void OnMove(InputValue value)
    {
        _moveXPoint =
            _camera.ScreenToViewportPoint(
                value.Get<Vector2>()).x - .5f;
    }

    private void OnRiseUp(InputValue value)
    {
        if (value.Get<float>() > 0)
        {
            _movement = new TakeoffMovement(_rigidbody, _movementData);

            _fireEffect.Play();

            return;
        }

        _movement = new FallMovement(_rigidbody, _movementData);

        _fireEffect.Stop();
    }

    private void FixedUpdate()
    {
        _movement.Move(Vector2.right * _moveXPoint);
    }
}



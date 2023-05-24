using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class PlayerFacade : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;

    private Camera _camera;

    private IMovement _movement;

    private float _moveXPoint;

    private void Awake()
    {
        _camera = Camera.main;

        _movement = new FallMovement(_rigidbody);
    }

    private void OnMove(InputValue value)
    {
        _moveXPoint = _camera.ScreenToViewportPoint(
                value.Get<Vector2>()).x - .5f;
    }

    private void OnRiseUp(InputValue value)
    {
        if (value.Get<float>() > 0)
        {
            _movement = new TakeoffMovement(_rigidbody);

            return;
        }

        _movement = new FallMovement(_rigidbody);
    }

    private void FixedUpdate()
    {
        _movement.Move(Vector2.right * _moveXPoint);
    }
}



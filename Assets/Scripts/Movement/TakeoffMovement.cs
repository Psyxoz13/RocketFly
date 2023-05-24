using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeoffMovement : IMovement
{
    private Rigidbody _rigidbody;

    public TakeoffMovement(Rigidbody rigidbody)
    {
        _rigidbody = rigidbody;
    }

    public void Move(Vector2 moveVector)
    {
        _rigidbody.MovePosition(moveVector);
    }
}

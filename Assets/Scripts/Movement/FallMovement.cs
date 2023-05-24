using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallMovement : IMovement
{
    private Rigidbody _rigidbody;

    public FallMovement(Rigidbody rigidbody)
    {
        _rigidbody = rigidbody;
    }

    public void Move(Vector2 moveVector)
    {
        
    }
}

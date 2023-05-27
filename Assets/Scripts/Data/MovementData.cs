using UnityEngine;

[CreateAssetMenu(fileName = "MovementData", menuName = "Data/MovementData", order = 51)]
public class MovementData : ScriptableObject
{
    [SerializeField] private float _angularSpeed = 15f;
    [SerializeField] private float _moveMaxSpeed = 10f;
    [SerializeField] private float _maxRiseUpSpeed = 4f;
    [SerializeField] private float _acceleration = 3f;
    [SerializeField] private float _brakingSpeed = 2f;

    [Space]
    [SerializeField] private float _maxHeightWorld = 0f;


    public float AngularSpeed => _angularSpeed;
    public float MoveMaxSpeed => _moveMaxSpeed;
    public float Acceleration => _acceleration;
    public float BrakingSpeed => _brakingSpeed;
    public float MaxRiseUpSpeed => _maxRiseUpSpeed;

    public float MaxHeightWorld => _maxHeightWorld;

}

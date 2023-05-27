using UnityEngine;

[CreateAssetMenu(fileName = "WallGenerateData", menuName = "Data/WallGenerateData", order = 51)]
public class WallGenerateData : ScriptableObject
{
    [SerializeField] private float _minWallProtrude = 1f;
    [SerializeField] private float _maxWallProtrude = 3f;

    [Space]
    [SerializeField] private int _minWallProtrudeOffsetCount = 1;
    [SerializeField] private int _maxWallProtrudeOffsetCount = 10;

    [Space]
    [SerializeField] private float  _fieldWidth= 12.25f;
    [SerializeField] private float  _betweenWallsDistance = 1f;

    public float MinWallProtrude => _minWallProtrude;
    public float MaxWallProtrude => _maxWallProtrude;

    public int MinWallProtrudeOffsetCount => _minWallProtrudeOffsetCount;
    public int MaxWallProtrudeOffsetCount => _maxWallProtrudeOffsetCount;

    public float FieldWidth => _fieldWidth;
    public float BetweenWallsDistance => _betweenWallsDistance;
}

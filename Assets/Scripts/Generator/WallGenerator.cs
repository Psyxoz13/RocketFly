using UnityEngine;

public class WallGenerator : Generator
{
    [SerializeField] private WallGenerateData _wallGenerateData;

    private static int _wallCount;
    private static int _nextWall = 40;

    private void Start()
    {
        
    }

    protected override GameObject Generate()
    {
        var generatedObject = _objectPool.GetObject();

        var position = generatedObject.transform.position;
        float xPosition = 0f;

        _wallCount++;

        if (_wallCount > _nextWall)
        {
            _nextWall = Random.Range(
                _wallGenerateData.MinWallProtrudeOffsetCount,
                _wallGenerateData.MaxWallProtrudeOffsetCount);

            if (_wallCount < 6) 
            {
                xPosition = Random.Range(
                    _wallGenerateData.MinWallProtrude,
                    _wallGenerateData.FieldWidth - _wallGenerateData.MaxWallProtrude - _wallGenerateData.BetweenWallsDistance) * 
                    generatedObject.transform.localScale.y;
            }
            else
            {
                xPosition =
                    Random.Range(
                        _wallGenerateData.MinWallProtrude,
                        _wallGenerateData.MaxWallProtrude) *
                        generatedObject.transform.localScale.y;
            }

            _wallCount = 0;
        }

        position.x = xPosition;
        generatedObject.transform.position = position;

        return generatedObject;
    }
}

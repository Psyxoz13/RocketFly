using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] private TraveledDistance _playerTraveledDistance;
    [SerializeField] private Generator[] _genereators;

    private void Awake()
    {
        Application.targetFrameRate = Screen.currentResolution.refreshRate;

        for (int i = 0; i < _genereators.Length; i++)
        {
            _genereators[i].Init();
        }
    }

    private void Update()
    {
        for (int i = 0; i < _genereators.Length; i++)
        {
             _genereators[i].PlaceObject(_playerTraveledDistance.Distance);
        }
    }
}

using Cinemachine;
using UnityEngine;

[ExecuteInEditMode] [SaveDuringPlay]
public class CinemachineFollowAxisLock : CinemachineExtension
{
    [SerializeField] private Vector3 _axis = Vector3.one;

    protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vCam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
    {
        if (stage == CinemachineCore.Stage.Body)
        {
            var position = state.RawPosition;
            position = new Vector3(
                position.x * _axis.x,
                position.y * _axis.y,
                position.z * _axis.z);

            state.RawPosition = position;
        }
    }

    private void OnValidate()
    {
        _axis.x = Mathf.RoundToInt(Mathf.Clamp01(_axis.x));
        _axis.y = Mathf.RoundToInt(Mathf.Clamp01(_axis.y));
        _axis.z = Mathf.RoundToInt(Mathf.Clamp01(_axis.z));
    }
}

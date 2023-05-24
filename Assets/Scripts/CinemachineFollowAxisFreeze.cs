using Cinemachine;
using UnityEngine;

[ExecuteInEditMode] [SaveDuringPlay]
public class CinemachineFollowXAxisLock : CinemachineExtension
{
    [SerializeField] private float _lockValue;

    protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vCam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
    {
        if (stage == CinemachineCore.Stage.Body)
        {
            var position = state.RawPosition;
            position.x = _lockValue;

            state.RawPosition = position;
        }
    }
}

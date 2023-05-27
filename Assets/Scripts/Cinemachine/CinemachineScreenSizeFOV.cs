using Cinemachine;
using UnityEngine;

[ExecuteInEditMode] [SaveDuringPlay]
public class CinemachineScreenSizeFOV : CinemachineExtension
{
    [SerializeField] private float _contentWidth = 16;

    protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
    {
        float width = (Screen.height * .5f / Screen.width) * _contentWidth;
        float fov = Mathf.Atan(width / state.FinalPosition.y) * Mathf.Rad2Deg * 2f;

        state.Lens.FieldOfView = fov;
    }
}

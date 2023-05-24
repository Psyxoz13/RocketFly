using UnityEngine;

public class FollowTargetZ : MonoBehaviour
{
    [SerializeField] private Transform target;

    void Update()
    {
        transform.position = Vector3.forward * target.position.z;
    }
}

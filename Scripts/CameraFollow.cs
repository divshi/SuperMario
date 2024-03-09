using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Target;
    public float Distance = 7;
    public float CameraY = 3;

    void Update()
    {
        transform.position = new Vector3(Target.position.x + 7, transform.position.y, Target.position.z - Distance);
    }

    void LateUpdate()
    {
        Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, CameraY, Camera.main.transform.position.z);
    }
}

using UnityEngine;

public class CameraMovement : MonoBehaviour {

    public Transform Robot;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = Robot.position + offset;
    }
}

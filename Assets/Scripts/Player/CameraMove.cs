using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public int speed;
    public float _mouseSensitivity;

    private float _rotationY;
    private float _rotationX;

    public GameObject pointCamera;

    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * _mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * _mouseSensitivity;

        _rotationY += mouseX;
        _rotationX += mouseY;

        transform.Rotate(Vector3.up, speed * mouseX * Time.deltaTime);
    }
}

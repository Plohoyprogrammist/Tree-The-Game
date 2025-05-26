using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public int speed;
    public float _mouseSensitivity;
    public float minYAngle = -80f;
    public float maxYAngle = 80f;

    public GameObject pointCamera;
    private float currentYRotation = 0f;

    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * _mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * _mouseSensitivity;

        transform.Rotate(Vector3.up, speed * mouseX * Time.deltaTime);
        pointCamera.transform.Rotate(Vector3.right, speed * -mouseY * Time.deltaTime);

        currentYRotation -= speed * mouseY * Time.deltaTime;
        currentYRotation = Mathf.Clamp(currentYRotation, minYAngle, maxYAngle);

        pointCamera.transform.localEulerAngles = new Vector3(currentYRotation, 0f, 0f);
    }
}

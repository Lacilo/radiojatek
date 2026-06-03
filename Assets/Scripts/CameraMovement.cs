using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float sensX = 100f;
    public float sensY = 100f;

    public Transform PlayerBody;
    public Transform Camera;

    float xRotation;
    float yRotation;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotation += mouseX;
        xRotation -= mouseY;

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        PlayerBody.Rotate(Vector3.up * mouseX);
        Camera.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
    }
}

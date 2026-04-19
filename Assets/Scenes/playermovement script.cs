using UnityEngine;

public class FPSController : MonoBehaviour {
    public float speed = 5f;
    public float sensitivity = 2f;
    private CharacterController controller;
    private float verticalRotation = 0f;

    void Start() {
        controller = GetComponent<CharacterController>();
        // Lock the cursor to the center of the screen
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update() {
        // 1. Rotation (Looking)
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        verticalRotation -= mouseY;
        verticalRotation = Mathf.Clamp(verticalRotation, -90f, 90f);
        Camera.main.transform.localRotation = Quaternion.Euler(verticalRotation, 0, 0);
        transform.Rotate(Vector3.up * mouseX);

        // 2. Movement (WASD)
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);
    }
}

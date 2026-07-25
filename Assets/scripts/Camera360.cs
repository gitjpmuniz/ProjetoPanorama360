using UnityEngine;

public class Camera360 : MonoBehaviour
{
    public float sensibilidade = 2f;

    private float rotacaoX = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensibilidade;
        float mouseY = Input.GetAxis("Mouse Y") * sensibilidade;

        rotacaoX -= mouseY;
        rotacaoX = Mathf.Clamp(rotacaoX, -90f, 90f);

        transform.localRotation = Quaternion.Euler(rotacaoX, transform.localEulerAngles.y + mouseX, 0);
    }
}

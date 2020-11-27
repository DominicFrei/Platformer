using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] CharacterController2D characterController2D = default;

    readonly string horizontalAxisName = RectTransform.Axis.Horizontal.ToString();
    readonly float runSpeed = 40f;

    float horizontalInput = 0f;
    bool verticalInput = false;

    void Update()
    {
        horizontalInput = Input.GetAxisRaw(horizontalAxisName);
        if (Input.GetButtonDown("Jump"))
        {
            verticalInput = true;
        }
    }

    void FixedUpdate()
    {
        characterController2D.Move(horizontalInput * runSpeed * Time.fixedDeltaTime, false, verticalInput);
        verticalInput = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{ 
    [SerializeField] CharacterController controller;
    [SerializeField] float speed = 11f;
    Vector2 horizontalInput;

    [SerializeField] float jumpHeight = 3.5f;
    bool Jump;
    [SerializeField] float gravity = -9.81f; // -9.81
    Vector3 verticalVelocity = Vector3.zero;
    [SerializeField] LayerMask groundMask;
    bool isGrounded;

    private void Update()
    {
        isGrounded = controller.isGrounded;
        if (isGrounded)
        {
            verticalVelocity.y = 0;
        }

        Vector3 horizontalVelocity = (transform.right * horizontalInput.x + transform.forward * 
            horizontalInput.y) * speed;
        controller.Move(horizontalVelocity * Time.deltaTime);

        // Jump: v = sqrt(-2 * jumpheight * gravity)
        if (Jump)
        {
            if (isGrounded)
            {
                 verticalVelocity.y = Mathf.Sqrt(-2f * jumpHeight * gravity);
                 Debug.Log("Jump");
            }
            Jump = false;
            
        }

        verticalVelocity.y += gravity * Time.deltaTime;
        controller.Move(verticalVelocity * Time.deltaTime);
    }

    public void ReceiveInput (Vector2 _horizontalInput)
    {
        horizontalInput = _horizontalInput;
        print(horizontalInput);
    }
    public void OnJumpPressed()
    {
        Jump = true;
    } 
}      

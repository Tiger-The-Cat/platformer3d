using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBall : MonoBehaviour
{
    public Transform playerBody;
    float speed = 12f;

    Vector3 velocity;

    public float gravity = -19.62f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    bool isGrounded;


    // Update is called once per frame
    void Update()
    {
        Vector2 playerInput;
        playerInput.x = Input.GetAxis("Horizontal");
        playerInput.y = Input.GetAxis("Vertical");
        playerInput = Vector2.ClampMagnitude(playerInput, 1f);

        Vector3 move = transform.right * playerInput.x + transform.forward * playerInput.y;

        transform.localPosition += move * speed * Time.deltaTime;
        //free fall
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)//check if on the ground and not jumping
        {
            velocity.y = 0f;//set to default
        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);//equation to get the ideal velocity with ideal height
        }

        velocity.y += gravity * Time.deltaTime;//*deltaTime so the frame rate wont effect speed

        transform.localPosition += velocity * Time.deltaTime;

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public PauseMenu menu;
    float horizontalMove = 0f;
    public float runSpeed = 40f;
    public Animator animator;
    bool crouch = false;
    bool moving;
    bool paused;

    // Update is called once per frame
    void Update()
    {
        moving = controller.canMove;
        paused = menu.GameIsPaused;
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if(moving && !paused)
        {
            animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        }
        else
        {
            animator.SetFloat("Speed", 0);
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
    }
    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, false);
    }
}
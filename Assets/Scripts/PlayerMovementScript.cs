using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    public bool P2 = false;
    public CharacterController2D controller;
    public Animator animator;
    float horizontalMove = 0f;
    public float runSpeed = 40f;
    bool jump = false;
    void Update()
    {
        horizontalMove = Input.GetAxisRaw(PlayerInputP2(P2)) * runSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if(Input.GetButtonDown(PlayerInputJumpP2(P2)))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }
    }

    string PlayerInputP2(bool player2)
    {
        if (player2 == false)
            return "Horizontal";
        else
            return "HorizontalP2";
    }

    string PlayerInputJumpP2(bool player2)
    {
        if (player2 == false)
            return "Jump";
        else
            return "JumpP2";
    }
    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }
    private void FixedUpdate()
    {
        controller.Move(horizontalMove* Time.fixedDeltaTime,jump);
        jump = false;
    }
}

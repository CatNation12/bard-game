using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public PlayerController controller;
    public Animator animator;

    public float runSpeed = 4.0f;

    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;



    private void Update()
    {

        horizontalMove = Input.GetAxisRaw("Horizontal") + runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));


        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        } else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false; 
        }





    }








}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This Script uses the control keys W and up to move the character in the scene and to animate the players walk when the buttons "w" and "up" are pressed.
// This script is attached to the main player character.
// Bools were created in Animator module for walking and not walking.
// The animation controller used is from the package "Cartoon Heroes" downloaded from Unity Store link is in readme file.

public class animationcontroller : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();    //calls the animator component attached to the player.
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            animator.SetBool("isWalking", true); //if w key is pressed set bool tagged is walking to true, apply animation
        }

        if (!Input.GetKey("w"))
        {
            animator.SetBool("isWalking", false); //if w key is not pressed set bool tag to false
        }

        if (Input.GetKey("up"))
        {
            animator.SetBool("isWalking", true); //tp get arrow button to apply animation I added this condition to the script
        }

        
    }
}

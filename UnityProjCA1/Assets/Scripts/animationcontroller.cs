using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This Script uses the animator controller to animate the main player wolf. I Watched various You Tube Tutorials inlcuding https://www.youtube.com/watch?v=vApG8aYD5aI&t=377s & https://www.youtube.com/watch?v=IurqiqduMVQ 

// This Script uses the control keys "W" and "up" to move the character in the scene and to animate the players walk when the buttons "w" and "up" are pressed.
// This script is attached to the main player character.
// Bools were created in Animator module for walking and not walking.
// The animation controller used is from the package "Cartoon Heroes" downloaded from Unity Store link is in readme file.
// Movements in the animation controller use the Attack movement at first, then to idle, then to walk when control buttons are pressed using the boolean function.

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
            animator.SetBool("isWalking", true); //if w key is pressed set bool tagged is walking to true, apply Male Sword walk animation.
        }

        if (!Input.GetKey("w"))
        {
            animator.SetBool("isWalking", false); //if w key is not pressed set bool tag to false, apply Idle animation state.
        }

        if (Input.GetKey("up"))
        {
            animator.SetBool("isWalking", true); //if up arrow is pressed set bool tagged to walking to true, apply Male Sword walk animation.
        }

        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script defines how the player moves throughout the game. It defines the speed,power & rotation of the players jump.

public class CharMovement : MonoBehaviour
{
    //public CharacterController controller;
    public float speed = 8f; //speed of player when moving
    public float jumpPower = 8f; //player can jump power of 8
    public float RotateSpeed = 20F; //how fast the player can rotate in game

    Rigidbody rb; //player is a rigid body
    CapsuleCollider col; //player is a collider

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<CapsuleCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        float Horizontal = Input.GetAxisRaw("Horizontal") * speed; //Gets Horizontal Position of player from the Input Manager
        float Vertical = Input.GetAxisRaw("Vertical") * speed; //Gets Vertical Position of player from the Input Manager
            Horizontal *= Time.deltaTime;
            Vertical *= Time.deltaTime;          
            transform.Translate(Horizontal, 0, Vertical); // Translates Player in the location given from Horizontal and Vertical information
            transform.Rotate(0, Horizontal * RotateSpeed, 0);  //Rotates the Player in the scene depending on the speed of the variable.
         
             if (isGrounded() && Input.GetKeyDown (KeyCode.Space)) //if player jumps using the space keybutton make the player move up depending on the jump power variable.
            {
                rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
            }
    
    }

        private bool isGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, col.bounds.extents.y + 0.1f); // if player is grounded, put player on the ground and can collide with objects.
    }
}

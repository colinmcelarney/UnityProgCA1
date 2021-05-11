using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//This script defines how the player moves throughout the game. It defines the speed and power of the players jump
public class CharMovement : MonoBehaviour
{
    //public CharacterController controller;
    public float speed = 8f; //speed of player when moving
    public float jumpPower = 8f; //player can jump power of 4
    public float RotateSpeed = 25F;
    Animator animator;


    Rigidbody rb; //player is a rigid body
    CapsuleCollider col; //player is a collider
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; 
        rb = GetComponent<Rigidbody>();
        col = GetComponent<CapsuleCollider>();
        animator = GetComponent<Animator>();
        

    }

    // Update is called once per frame
    void Update()
    {
        float Horizontal = Input.GetAxisRaw("Horizontal") * speed;
        float Vertical = Input.GetAxisRaw("Vertical")* speed;
            Horizontal *= Time.deltaTime;
            Vertical *= Time.deltaTime;
            //Vector3 direction = new Vector3(Horizontal, 0f, Vertical).normalized * Time.deltaTime;
            transform.Translate(Horizontal, 0, Vertical);
            transform.Rotate(0, Horizontal * RotateSpeed, 0);


            //if (Input.GetKeyDown (KeyCode."w"))
            //{
             //   animator.SetBool("isWalking", true);
            //}

            if (isGrounded() && Input.GetKeyDown (KeyCode.Space))
            {
                rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
           }

            /*if (direction.magnitude >= 0.1f)
            {
                float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);

                controller.Move(direction * speed * Time.deltaTime);
            }
            if (Input.GetKeyDown("escape"))
            Cursor.lockState = CursorLockMode.None; *///if user presses the escape button the mouse position becomes back in focus
    }

        private bool isGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, col.bounds.extents.y + 0.1f);
    }
}

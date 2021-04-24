using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//This script defines how the player moves throughout the game. It defines the speed and power of the players jump
public class CharMovement : MonoBehaviour
{
    public float speed = 30; //speed of player when moving
    public float jumpPower = 8; //player can jump power of 4
    

    

    Rigidbody rb; //player is a rigid body
    CapsuleCollider col; //player is a collider
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; 
        rb = GetComponent<Rigidbody>();
        col = GetComponent<CapsuleCollider>();
        

    }

    // Update is called once per frame
    void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal") * speed;
        float Vertical = Input.GetAxis("Vertical") * speed;
            Horizontal *= Time.deltaTime;
            Vertical *= Time.deltaTime;
            transform.Translate(Horizontal, 0, Vertical);

            if (isGrounded() && Input.GetKeyDown (KeyCode.Space))
            {
                rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
            }
            if (Input.GetKeyDown("escape"))
            Cursor.lockState = CursorLockMode.None; //if user presses the escape button the mouse position becomes back in focus
    }

        private bool isGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, col.bounds.extents.y + 0.1f);
    }
}

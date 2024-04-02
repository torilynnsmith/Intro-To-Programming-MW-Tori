using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //IN CLASS CCNY MW

    //NOTE
    //Make a Camera follow your Player
    //1. Install Cinemachine via the Package Manager
    //2. Add a 2D Camera (Right Click Hierarchy -> Cinemachine -> 2D Camera
    //3. This will make the new Camera your Main Camera
    //4. Drag the Player Object into the 2D camera's follow field.
    //That's it! 

    //GLOBAL VARIABLES
    public Rigidbody2D playerBody; //set Rigidbody variable for the player in Inspector

    public float playerSpeed = 0.05f; //declare and set playerSpeed
    public float jumpForce = 300; //declare and set jumpForce
    public bool isJumping = false; //declare and set a bool for if we're jumping or not to false (b/c we're not jumping when the game starts) 

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer(); //call MovePlayer() function
        Jump(); //call Jump() function
    }

    //Move Player Left & Right via A & D keys
    private void MovePlayer()
    {
        Vector3 newPos = transform.position; //declare and set a new Vector3 variable, newPos (New Position)

        if (Input.GetKey(KeyCode.A)) //If A Key is pressed
        {
            //Debug.Log("A pressed"); //print to console
            newPos.x -= playerSpeed; //affect x coordinate, move left
        }
        else if (Input.GetKey(KeyCode.D))
        {
            //Debug.Log("D pressed"); //print to console
            newPos.x += playerSpeed; //affect x coordinate, move right
        }
        transform.position = newPos; //update player object with the new position
    }

    //Jump Player via Spacebar
    private void Jump()
    {
        if (!isJumping && Input.GetKeyDown(KeyCode.Space)) //when the Spacebar is pressed and isJumping is false (first frame only)
                                                           //this disallows infinite jumping. you could alter the isJumping bool to and int to allow for differend amounts of jumping, i.e. Double Jumping!
        {
            playerBody.AddForce(new Vector3(playerBody.velocity.x, jumpForce, 0)); //apply force in decided direction (y axis)
                                                                                   //Similar to launching our Pong Ball! We're just declaring the new Vector 3 in the same line.
                                                                                   //This Vector 3 keeps the same velocity.x (to keep moving in whatever x direction), but changes the y to jumpForce, and doesn't change the z at all. 
            isJumping = true; //set isJumping to true
        }
    }

    //check collisions
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //when colliding with a surface (ground, safe obstacles, etc., anything tagged with "Surface")
        if (collision.gameObject.tag == "Surface")
        {
            isJumping = false; //set isJumping to false
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    //IN CLASS SCRIPT - COLLEGE NOW SPRING 2024

    //GLOBAL / UNIVERSAL VARIABLES
    public Rigidbody2D rbPaddle; //declare Rigidbody2D varialbe, set in inspector via drag & drop
    //our paddle has a Kinematic Rigidbody type!
    public float paddleSpeed = 0.05f; //declare and set paddleSpeed float

    public bool isPlayer1; //declare a boolean (true/false) for isPlayer1. Set in inspector 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayer1) //if player 1...
        {
            Player1Control(); //call Player1Control()
        } else //if plaer 2
        {
            Player2Control(); //call Player2Control()
        }
    }

    private void Player1Control()
    {
        //Debug.Log("this is player 1");
        Vector3 newPos = transform.position; //declare and set a new Vector 3 variable with the current position of the object this script is attached to.

        //if paddle is w/i play area, allow movement
        if (newPos.y <= 4.1f && newPos.y >= -4.1f) //tweak these y coordinates based on your preference. coordinates are in the MIDDLE of the sprite
        {
            if (Input.GetKey(KeyCode.W)) //as long as W is being pressed...
            {
                //Debug.Log("W pressed");
                newPos.y += paddleSpeed; //add paddSpeed value to the y coordinates
                //moves the y coordinates UP
            }
            else if (Input.GetKey(KeyCode.S)) //as long as S is being pressed...
            {
                //Debug.Log("S pressed");
                newPos.y -= paddleSpeed; //subtracts paddSpeed value to the y coordinates
                //moves the y coordinates DOWN
            }
            //update paddle 1 w/ new position
            transform.position = newPos;
        }
        //reset paddle to be w/i the play area
        if (newPos.y >= 4.1f) //if y coordinates are greater than or equal to 4.1f...
        {
            newPos.y = 4; //set y coords to 4
            transform.position = newPos; //apply the new y coordinates and move the paddle back w/i play area
        } else if (newPos.y <= -4.1f) //if y coordinates are less than or equal to -4.1f...
        {
            newPos.y = -4; //set y coords to -4
            transform.position = newPos; //apply the new y coordinates and move the paddle back w/i play area
        }
    }

    private void Player2Control()
    {
        //FIX ME! WRITE CONTROLS FOR PLAYER 2
    }
}

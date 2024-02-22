using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    //mw in class
    //GLOBAL VARIABLES
    public Rigidbody2D rbPaddle;//get RigidBody2D component
                                //HOT TIP: set RigidBody to Kinematic so they don't go flying if hit with the Ball
    public bool isPlayer1; //set which player it is, P1 or P2?
    public float paddleSpeed = 0.05f; //declare and set paddleSpeed

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Paddle Script! Yay!");
        //paddleSpeed = 0.05f;

    }

    // Update is called once per frame
    void Update()
    {
        //if an object is Player1 (set in Inspector) use one set of controls over the other
        if (isPlayer1)
        {
            Player1Control(); //call Player1Control() function
        }
        else
        {
            Player2Control(); //call Player2Control() function
        }
    }

    void Player1Control()
    {
        //Debug.Log("is player 1");
        Vector3 newPos = transform.position; //declare a new Vector3 variable, newPos (New Position)

        //If paddle is w/i play area, allow movement
        //NOTE: We've set our border values here to approximately where the paddles would hit the Wall objects. You might have to tweak these values. 
        //Basically, this is hardcoding collision! 
        if (newPos.y <= 4.1f && newPos.y >= -4.1f) 
        {
            //PLAYER MOVEMENT CONTROLS
            if (Input.GetKey(KeyCode.W)) //if W is pressed...
            {
                //Debug.Log("W key pressed");
                newPos.y += paddleSpeed; //affect y coordinate up = move paddle up
            }
            else if (Input.GetKey(KeyCode.S)) //if S is pressed...
            {
                //Debug.Log("S Key Pressed");
                newPos.y -= paddleSpeed; //affect y coordinate down = move paddle down
            }
            transform.position = newPos; //update player 1 paddle with the new position
        }

        //if paddle leaves the play area, reset paddle to be within the play area
        if (newPos.y >= 4.1f) //if the y position is greater than or equal to 4.1...
        {
            newPos.y = 4; //set the y position value to 4f
            transform.position = newPos; //update player 1 paddle with the new position
        }
        else if (newPos.y <= -4.1f) //if the y position is less than or equal to -4...
        {
            newPos.y = -4; //set the y position value to -4f
            transform.position = newPos; //update player 1 paddle with the new position
        }

    }

    void Player2Control()
    {
        //Debug.Log("is player 2");
        Vector3 newPos = transform.position; //declare a new Vector3 variable, newPos (New Position)

        //If paddle is w/i play area, allow movement
        //NOTE: We've set our border values here to approximately where the paddles would hit the Wall objects. You might have to tweak these values. 
        //Basically, this is hardcoding collision! 
        if (newPos.y <= 4.1f && newPos.y >= -4.1f)
        {
            //PLAYER MOVEMENT CONTROLS
            //This is the same process as Player1Control! Just with different KeyCodes
            if (Input.GetKey(KeyCode.UpArrow)) //if Up Arrow is pressed
            {
                //Debug.Log("W key pressed");
                newPos.y += paddleSpeed; //affect y coordinate up = move paddle up
            }
            else if (Input.GetKey(KeyCode.DownArrow)) //if Down Arrow is pressed
            {
                //Debug.Log("S Key Pressed");
                newPos.y -= paddleSpeed; //affect y coordinate down = move paddle down
            }
            transform.position = newPos; //update player 2 paddle with new position
        }

        //if paddle leaves the play area, reset paddle to be within the play area
        if (newPos.y >= 4.1f) //if the y position is greater than or equal to 4.1...
        {
            newPos.y = 4; //set the y position value to 4f
            transform.position = newPos; //update player 2 paddle with new position
        }
        else if (newPos.y <= -4.1f) //if the y position is greater than or equal to 4.1...
        {
            newPos.y = -4; //set the y position value to -4f
            transform.position = newPos; //update player 2 paddle with new position

        }
    }
}
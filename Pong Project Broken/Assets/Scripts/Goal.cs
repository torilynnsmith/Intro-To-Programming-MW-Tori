using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    //IN CLASS COLLEGE NOW

    //GLOBAL VARIABLES
    public bool isPlayer1Goal; //declare boolean, set in inspector

    public GameManager myManager; //declare a Game Manager script, set in inspector with object the script is attached to

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //EVENTS UPON ENTERING/"COLLIDING" WITH A TRIGGER
    private void OnTriggerEnter2D(Collider2D collision) //MAKE SURE THIS IS 2D!!! Won't work without the 2D qualifier
                                                        //you could also do this as a true collision on the walls, but I want you to see how triggers work!
                                                        //If a collider is a trigger, objects will pass right through it, but a "collision" will still be registered

    {
        if (collision.gameObject.tag == "Ball") //if something with the Ball tag collides with the Goal areas
        {
            //PLAYER 2 SCORES
            if (isPlayer1Goal) //if the Trigger is on the Player 1 Goal (check your bool!)
            {
                //Debug.Log("Player 2 Scored");
                myManager.Player2Scored(); //call the Player2Scored() funciton from the Game Manager

            }
            //PLAYER 1 SCORES
            else //if the Trigger is on the Player 2 Goal
            {
                //FIX ME!!! CALL THE PLAYER1SCORED() FUNCTION! 
            }
        }
    }
}

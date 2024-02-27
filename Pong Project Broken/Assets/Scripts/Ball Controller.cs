using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
    //IN CLASS SCRIPT - COLLEGE NOW
{
    //UNIVERSAL/GLOBAL VARIABLES
    public Rigidbody2D rbBall; //get Rigidbody 2D component from sprite, set in Inspector

    public float force = 200; //delcare and set force/velocity

    private float xDir; //declare x direction float
    private float yDir; //declare y direction float

    public bool inPlay; //set to true/false if ball is in Play, settable in Inspector
    public Vector3 ballStartPos; //ball starting position, set in the Inspector

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("hello world!"); //print to console

        Launch(); //call Launch function

    }

    // Update is called once per frame
    void Update()
    {
        //Check if the Ball is currently in play
        if (inPlay == false) //if ball is not in play...
        {
            transform.position = ballStartPos; //reset the ball to it's start position
            Launch(); //call Launch function
        }
    }

    //Launch the ball
    private void Launch()
    {
        //Debug.Log("Launch() Called.");
        Vector3 direction = new Vector3(0, 0, 0); //declare a new variable, a Vector 3
        //Vector3 (x,y,z) = represenation of 3D vectors and points (can still be used in 2D projects!)

        //Set direction.x (which way the ball moves horizontally)
        xDir = Random.Range(0, 2); //pick a random int b/w 0 & 1
        if (xDir == 0) //if 0...
        {
            direction.x = -1; //...set direction.x = -1, then go left
            //Debug.Log("Ball went Left");

        }
        else if (xDir == 1) //if 1...
        {
            direction.x = 1; //...set direction.x = 1, then go right
            //Debug.Log("Ball went Right");
        }

        //FIX ME!!!! SET LAUNCH DIRECTION Y! 
        //Set direction.y (which way the ball moves veritcally)


        rbBall.AddForce(direction * force); //launch the ball (apply force in a direction on the RigidBody)
        inPlay = true; //ball is now in play, = true
        //Debug.Log("inPlay = " + inPlay); 
    }

    //EVENTS UPON COLLISION
    private void OnCollisionEnter2D (Collision2D collision)
    {
        //if the ball collides with the left or right wall....
        if (collision.gameObject.name == "Wall Left" || collision.gameObject.name == "Wall Right")
        {
            //Debug.Log("hit Left or Right Wall");
            rbBall.velocity = Vector3.zero; //stop the ball's momentum, set velocity vector to (0,0,0)
            //Vector 3 (0,0,0)
            inPlay = false; //set in play equal to false
                //setting inPlay = false will trigger the if check we have in Update()
        }
    }

}

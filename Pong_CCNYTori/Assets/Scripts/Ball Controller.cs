using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    //CCNY M/W In-Class Script

    //GLOBAL VARIALBES
    public Rigidbody2D rbBall; //declare Rigidbody2D variable, set in Inspector via drag and dropping

    public float force = 200; //decare and set force variable

    private float xDir; //declare x direction float
    private float yDir; //declare y direction float

    public bool inPlay; //set to true/false if ball is in Play, set in Inspector
    public Vector3 ballStartPos; //Ball starting position, set in Inspector

    // Start is called before the first frame update
    void Start()
    {
        //This is a comment! 
        //Debug.Log("hello world"); //print to console

        Launch(); //call the Launch Function at Start
    }

    // Update is called once per frame
    void Update()
    {
        //Check if Ball is in Play
        if (inPlay == false) //if Ball is NOT in Play
        {
            transform.position = ballStartPos; //set Ball to start position
            Launch(); //call Launch() to automatically relaunch the Ball
        }
    }

    void Launch()
    {
        Vector3 direction = new Vector3(0, 0, 0); //declare and set a new Vector 3 variable
                                                  //Vector3 (x,y,z) = represenation of 3D vectors and points (can still be used in 2D projects!)

        //Set direction.x (which way the ball moves horizontally)
        xDir = Random.Range(0, 2); //pick a random int b/w 0 & 1
        //Debug.Log("xDir = " + xDir);
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

        //Set direction.y (which way the ball moves veritcally)
        yDir = Random.Range(0, 2); //pick a random int b/w 0 & 1
        if (yDir == 0) //if 0...
        {
            direction.y = -1; //..set direction.y = -1, go down
            //Debug.Log("Ball went down");
        }
        else if (yDir == 1) //if 1...
        {
            direction.y = 1; //..set direction.y = -1, go up
            //Debug.Log("Ball went up");
        }

        //add force to start movemnt
        rbBall.AddForce(direction * force); //launch the ball (apply force in a direction on the RigidBody)
        inPlay = true;
    }

    //EVENTS UPON VOLLISION
    private void OnCollisionEnter2D(Collision2D collision) //MAKE SURE THIS IS 2D!!! Won't work without the 2D qualifier
        //FOR COLLISIONS TO WORK: both objects must have colliders on them
    {
        //Debug.Log("object that collided w/ Ball: " + collision.gameObject.name);

        //when Ball collides with Left or Right Walls, reset to original position at ballStartPos & change score
        if (collision.gameObject.name == "Left Wall" || collision.gameObject.name == "Right Wall")
        {
            //Debug.Log("collided with Left/Right Wall");
            rbBall.velocity = Vector3.zero; //zeros out the force being applied to Ball so the force doesn't stack
            inPlay = false; //set inPlay to False, will cause the inPlay check in Update() to reset the position and automatically Launch()
        }

    }
}

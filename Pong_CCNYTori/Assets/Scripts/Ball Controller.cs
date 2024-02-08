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

    // Start is called before the first frame update
    void Start()
    {
        //This is a comment! 
        //Debug.Log("hello world"); //print to console

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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

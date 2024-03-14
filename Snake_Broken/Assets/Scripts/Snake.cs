using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq; 

public class Snake : MonoBehaviour
{
    //COLLE NOW IN CLASS MW

    //GLOBAL VARIABLES
    Vector3 dir = Vector3.right; //decare default movement direction
                                 //Remember the difference b/w Vector2(x,y) & Vector3(x,y,z)
                                 //there is shorthand for Vector2/3 directions.
                                 //In this one, Vector3.right = Vector3(1,0,0), moving it to the RIGHT

    //Keep Track of Tail Elements
    List<Transform> tail = new List<Transform>(); //declare a new list variable
        //This list keeps track of the Transform compenents of objects in the list
    bool ate = false; //set a bool to determine if the snake has eaten something. Will change upon Trigger w/ FoodPrefabs
    public GameObject tailPrefab; //set the TailPrefab in the Inspector to Instantiate it through code.

    public GameManager myManager; //reference to the GameManager script, set in Inspector

    // Start is called before the first frame update
    void Start()
    {
        //OPTIONAL: Randomize the direction of the snake like our Pong Ball when it starts

        //FIX ME! Call MoveSnake() every 300ms(0.3 seconds) to move the snake

    }

    // Update is called once per frame
    void Update()
    {
        //FIX ME! Change the Snake's direction by calling a function w/i this script
    }

    //Make the snake move
    void MoveSnake()
    {
        //SAVE THE CURRENT POSITION (Where the head "previously" was. This is the gap that tail parts will move into)
        Vector3 gap = transform.position;

        //MOVE SNAKE HEAD IN A DIRECTION
        transform.Translate(dir);

        //Check if the snake has eaten something (ate = true)
        //NOTE: if ate is never changed to false upon a Trigger Collision with the Food, this code won't run!
        if (ate)
        {
            //Debug.Log("ate =" + ate);

            //FIX THE FOLLOWING LINE THAT'S COMMENTED OUT: Load the TailPrefab intro the scene as a tailSec (Tail Section) GameObject
            //GameObject tailSec = (GameObject)Instantiate(???, ???, ???);

            //UNCOMMENT ME WHEN LINE 54 IS FIXED! Keep track of this tail section in our tail list
            //tail.Insert(0, tailSec.transform);

            //FIX ME! reset the ate bool so we can eat again!

        }

        //Otherwise, check if snake has a tail
        else  if (tail.Count > 0) //if the Tail amount is greater than 0, then...
        {
            //move the last Tail to where the Head previously was
            tail.Last().position = gap;

            //Keep our Tail List in order!
            //Add Last Tail element to the front of the list and remove from the back
            tail.Insert(0, tail.Last()); //move the Last Tail section to be first in the list
            tail.RemoveAt(tail.Count - 1); //reduce the list amount by 1
            //Basically, these line of code move through each tail section only ONCE to tell it to move into the gap after the tail section preceding it has.
            //Then it will stop.
        }
    }

    //Change the Snakes movement direction when a Key is pressed
    private void ChangeDirection()
    {
        if(Input.GetKey(KeyCode.RightArrow)) //if the Right Arrow is continuously pressed down, then...
        {
            dir = Vector3.right; //change the direction to RIGHT
            //Debug.Log("direction = right"); //print to console
        }//FIX ME! Add controls for the other 3 directions 

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //When Snake collides with Food...
        if (collision.gameObject.tag == "Food")
        {
            ate = true; //set ate bool to True
                //See the MoveSnake() function for making the snake longer

            //Debug.Log("food eaten");
            //FIX ME: Remove the Food

            //Change Score
            //FIX ME: call the Food Eaten Function in the GameManager script to change the score.
        }
        //OPTIONAL: write code so that if the snake head collides with the wall, it resets.
    }
}

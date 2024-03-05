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

    // Start is called before the first frame update
    void Start()
    {
        //OPTION: Randomize the direction of the snake like our Pong Ball when it starts

        //Call MoveSnake() every 300ms(0.3 seconds) to move the snake
        InvokeRepeating("MoveSnake", 0.3f, 0.3f);
        //InvokeRepeating("methodName", time, repeatRate)
        //methodName: name of method/function to invoke
        //time: start invoking after n seconds
        //repeatRate: repeat after every n seconds.
    }

    // Update is called once per frame
    void Update()
    {
        //NOTE: if we did movement in update, it would go SUPER FAST, so let's call it on a delay in Start()

        //Change the Snake's direction by calling ChangeDirection(), detecting key presses all the time
        ChangeDirection(); 
    }

    void MoveSnake()
    {
        //SAVE THE CURRENT POSITION (Where the head "previously" was. This is the gap that tail parts will move into)
        Vector3 gap = transform.position;

        //In Snake, the snake is ALWAYS moving in some direction, never standing still.
        //MOVE SNAKE HEAD IN A DIRECTION
        transform.Translate(dir);
        //Translate moves the transform property in the direction and distance of the translation,
        //In this case, we are moving in the whatever direction we've set the dir variable to be the distance of that variable

        //Check if the snake has eaten something (ate = true)
        //NOTE: if ate is never changed to false upon a Trigger Collision with the Food, this code won't run!
        if (ate)
        {
            //Debug.Log("ate =" + ate);

            //Load the TailPrefab intro the scene as a tailSec (Tail Section) GameObject
            GameObject tailSec = (GameObject)Instantiate(tailPrefab, gap, Quaternion.identity);
            //This works similarly to Instantiating our food prefabs into the scene! We're just combining 2 lines of code into 1
            //1. We've declared a new GameObject variable
            //2. We've filled in the 3 parameters for Instatiating:
            //1. the name of the gameObject we're instantiating (tailPrefab)
            //2. where (position(x,y,z)) we're instantiating it (gap)
            //3. the rotation at which we're instantiating it (Quaternion.identity)

            //Keep track of this tail section in our tail list
            tail.Insert(0, tailSec.transform);

            //reset the ate bool so we can eat again!
            ate = false; 
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

    private void ChangeDirection()
    {
        if(Input.GetKey(KeyCode.RightArrow)) //if the Right Arrow is continuously pressed down, then...
        {
            dir = Vector3.right; //change the direction to RIGHT
            //Debug.Log("direction = right"); //print to console
        }//MOVE LEFT
        else if (Input.GetKey(KeyCode.LeftArrow)) //if the Left Arrow is continuously pressed down, then...
        {
            dir = Vector3.left; //change the direction to LEFT
                                //NOTE: this could also be written as dir = - Vector3.right, "-right" = left
                                //Debug.Log("direction = left"); //print to console
        }//MOVE UP
        else if (Input.GetKey(KeyCode.UpArrow)) //if the Up Arrow is continuously pressed down, then...
        {
            dir = Vector3.up; //change the direction to UP
            //Debug.Log("direction = up"); //print to console
        }//MOVE DOWN
        else if (Input.GetKey(KeyCode.DownArrow)) //if the Down Arrow is continuously pressed down, then...
        {
            dir = Vector3.down; //change the direction to DOWN
            //Debug.Log("direction = down"); //print to console
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //When Snake collides with Food...
        if (collision.gameObject.tag == "Food")
        {
            ate = true; //set ate bool to True
                //See the MoveSnake() function for making the snake longer

            //Debug.Log("food eaten");
            Destroy(collision.gameObject); //Remove the Food

        }
        //DIY: write code so that if the snake head collides with the wall, it resets.
    }
}

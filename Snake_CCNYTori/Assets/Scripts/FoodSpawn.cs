using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawn : MonoBehaviour
{
    //MW CCNY IN CLASS SCRIPT

    //GLOBAL VARIABLES
    public GameObject foodPrefab;

    //Border positions
    //Get Border Positions (so we can spawn the food within them)
    public Transform wallTop;
    public Transform wallBottom;
    public Transform wallLeft;
    public Transform wallRight; 

    // Start is called before the first frame update
    void Start()
    {
        //Invoke("Spawn", 4); //Spawn food one time 3 seconds after the Invoke is called
        InvokeRepeating("Spawn", 3, 4); //Spawn food every 4 seconds, 3 seconds after InvokeRepeating is called the first time
                                        //NEXT STEPS: change this to a single Invoke and then only instantiate a new food after the previous one has been eaten (use a bool!)

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Spawn one piece of food w/i the game's borders
    void Spawn()
    {
        //Debug.Log("Spawn Called");

        //set x position b/w Left & Right borders
        int xPos = (int)Random.Range(wallLeft.position.x, wallRight.position.x);
        //int xPos = (int)Random.Range(borderLeft.position.x + 5, borderRight.position.x - 5);
        //randomly set the xPos of the food's position to a random integer between the x position values of the Left and right borders
        //NOTE that we are rounding to INTEGERS, not FLOATS
        //ALSO NOTE that you could add/subtract an integer from each position, to give our Random Range a little extra buffer and prefent food from accidentally spawning within the borders themselves. 


        //set y position b/w Bottom & Top borders
        int yPos = (int)Random.Range(wallTop.position.y, wallBottom.position.y);
        //int yPos = (int)Random.Range(borderBottom.position.y + 5, borderTop.position.y - 5);
        //randomly set the yPos of the food's position to a random integer between the y position values of the Bottom & Top borders

        //INSTANTIATE the food at (xPos, yPos) cooordinates
        Instantiate(foodPrefab, new Vector3(xPos, yPos, 0), Quaternion.identity);
        //Instantiate (original, position, rotation)
        //Instantiate creates a new instance of a game object. It has 3 parameters:
        //1. The name of the existing object you want to make a copy of (plug in the variable we made!)
        //2. The position for the new object, declare a new Vector3 and plug in our xPos, yPos variables we just set
        //3. The orientation/rotation of the new object
        //WHAT IS A QUATERNION? Quaternions represent rotation and are relatively complex.
        //We may get into them later, but just use Quaternion.identity to set them for now. This is the default!
		//Remember: NO IDENTITY CRISES! 

    }
}

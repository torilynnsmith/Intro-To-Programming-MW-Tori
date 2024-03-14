using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawn : MonoBehaviour
{
    //MW CCNY IN CLASS SCRIPT

    //GLOBAL VARIABLES
    public GameObject foodPrefab;

    //Border positions
    //Get Border Positions (so we can spawn the food within them), set in Inspector
    public Transform wallTop;
    public Transform wallBottom;
    public Transform wallLeft;
    public Transform wallRight; 

    // Start is called before the first frame update
    void Start()
    {
        //FIX ME!!!
        //Spawn food one time 3 seconds after Start
        //OR
        //Spawn food every 4 seconds, 3 seconds after InvokeRepeating is called the first time
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

        //FIX ME! set y position b/w Bottom & Top borders

        //FIX ME!!! INSTANTIATE the food at (xPos, yPos) cooordinates

    }
}

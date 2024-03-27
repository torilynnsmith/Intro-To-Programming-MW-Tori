using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToMouse : MonoBehaviour
{
    //IN CLASS CCNY MW

    //GLOBAL VARIABLES
    public float speed = 5f; //set speed, can change in inspector
    private Vector3 target; //declare target variable, where the moving object will try to move to

    // Start is called before the first frame update
    void Start()
    {
        target = transform.position; //set the target to the starting position of the object (it won't be moving at first)

    }

    // Update is called once per frame
    void Update()
    {
        //TO DO: A CHECK TO SEE IF AN ITEM IS BEING DRAGGED OR NOT TO KEEP THIS FROM CHASING THE MOUSE POSITION

        if (Input.GetMouseButtonDown(0)) //if left mouse button is clicked...
                                         //similar to GetKey stuff! GetMouseButtonDown only returns for the first frame the mouse button is clicked
                                         //0 = Left Mouse, 1 = Right Mouse
        {
            Debug.Log("click to move");
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition); //similar to our Draggable Sprite script!

            target.z = transform.position.z; //LOCK THE Z AXIS FOR 2D GAMES
            //Debug.Log("target =" + target); 
        }
        //MOVE THE OBJECT
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        //MoveTowards calculates a position b/w the starting position and the target position, moving there as quickly as set by the speed. 
    }
}

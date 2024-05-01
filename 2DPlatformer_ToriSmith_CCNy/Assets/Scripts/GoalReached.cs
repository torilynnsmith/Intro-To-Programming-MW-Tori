using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //use the Scene Management Library (to switch scenes)

public class GoalReached : MonoBehaviour
{
    //IN CLASS CCNY
    //This script lives on the End Goal Post at the end of my level to switch scenes (and maybe some other stuff)
    //This is similar in function to our "Goal" script from Pong!

    //GLOBAL VARIABLES
    public int sceneID; //set in inspector to the scene you want to go to (check the number in your Build Settings) 
        //In my game, the Game over scene is scene ID = 2.
       
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Events upon stuff colliding with this trigger
    private void OnTriggerEnter2D(Collider2D collision)
           //Remember: Trigger colliders are like ghosts! stuff moves through them! 
    {
        //if the player collides with this trigger
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("End of Level."); 
            SceneManager.LoadScene(sceneID); //Load the requested scene (check the number of the scene you want in your build settings) 
        }
    }
}

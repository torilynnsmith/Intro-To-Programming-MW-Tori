using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //use Scene Management Library

public class SceneChanger : MonoBehaviour
{
    //IN CLASS CCNY

    //This Script Lives on the Game Manager Object.
    //NOTE: Don't forget to add the scenes you want to switch between into your Build Settings! 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //CHANGE SCENE W/ BUTTON AND SCENE ID.
    public void MoveToScene(int sceneID) //added in a "value parameter", similar to our Collision 2D code!
    {
        //SceneManager.LoadScene("End Scene"); //call a scene specifically by it's name
        //OR
        SceneManager.LoadScene(sceneID);
        //load a scene based on its Scene ID # in Build Settings.
        //Set this number in the Inspector
    }
}

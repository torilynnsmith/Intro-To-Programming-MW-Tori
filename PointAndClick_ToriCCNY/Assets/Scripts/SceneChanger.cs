using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //use Scene Management Library

public class SceneChanger : MonoBehaviour
{
    //CCNY MW IN CLASS

    //GLOBAL VARIABLES
    public int sceneNumber;
        //0 = StartScene
        //1 = MainScene
        //2 = EndScene

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (sceneNumber == 0) //we're in the start scene
        {
            StartSceneControls(); 
        } else if (sceneNumber == 1) //we're in the main scene
        {
            MainSceneControls(); 
        } else if (sceneNumber == 2) //we're in the end scene
        {
            EndSceneControls(); 
        }

    }

    public void StartSceneControls()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("MainScene");
        }
    }

    public void MainSceneControls()
    {
        Debug.Log("main scene controls");
    }

    public void EndSceneControls()
    {
        Debug.Log("end scene controls"); 
    }
}

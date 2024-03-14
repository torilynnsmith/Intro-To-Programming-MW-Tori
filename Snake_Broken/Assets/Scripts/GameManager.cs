using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class GameManager : MonoBehaviour
{
    //IN CLASS CCNY M/W

    //GLOBAL VARIABLES
    public TextMeshProUGUI foodScoreText; //Text Object for Food Score Text
    public int foodScore = 0; //declare and set initial Food Score

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //FIX ME!!! update foodScoreText UI
    }

    //To be run when Food is Eaten....
    public void FoodEaten() 
    {
        //FIX ME!!! add 1 to food score
    }
}

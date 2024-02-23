using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class GameManager : MonoBehaviour
{
    //MW CCNY CLASS

    //GLOBAL VARIABLES
    //game objects for UI Elements
    public TextMeshProUGUI player1ScoreText; //Text Object for Player 1 Score, set in inspector
    public TextMeshProUGUI player2ScoreText; //Text Object for Player 2 Score, set in inspector

    //SCORES
    private int player1Score = 0; //declare and set integer variable for Player 1 Score
    private int player2Score = 0; //declare and set integer variable for Player 2 Score

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //update the player scores
        player1ScoreText.text = "P1: " + player1Score;
        player2ScoreText.text = "P2: " + player2Score;
    }

    //When Player 1 Scores, run this function
    //NOTE: This is a PUBLIC void
    public void Player1Scored()
    {
        player1Score++; //add 1 to score value
    }

    //When Player 2 Scores, run this function
    //NOTE: This is a PUBLIC void
    public void Player2Scored()
    {
        player2Score++; //add 1 to score value
    }
}

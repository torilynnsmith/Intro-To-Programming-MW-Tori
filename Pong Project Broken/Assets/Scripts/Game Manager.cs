using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //add in new Library to use the UI elements

public class GameManager : MonoBehaviour
{
    //IN CLASS COLLEGE NOW

    //Global Variables
    //Game Objects for UI Elements
    public TextMeshProUGUI player1ScoreText; //Text Object for Player 1 Score, set in inspector
    public TextMeshProUGUI player2ScoreText; //Text Object for Player 2 Score, set in inspector

    //Scores
    private int player1Score = 0; //declare and set integer variable for Player 1 Score
    private int player2Score = 0; //declare and set integer variable for Player 2 Score

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //update player score UI
        player1ScoreText.text = "P1: " + player1Score; //update Player 1's Score UI
        //FIX ME!!! update Player 2's Score UI
    }

    //When Player 1 Scores, run this function
    //NOTE: This is a PUBLIC void
    public void Player1Scored()
    {
        player1Score ++; //add 1 to score value
    }

    //When Player 2 Scores, run this function
    //NOTE: This is a PUBLIC void
    public void Player2Scored()
    {
        //FIX ME!!! add 1 to score value
    }
}

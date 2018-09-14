using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMasher : MonoBehaviour {

    //Data for our class
    public AudioSource clickSound; //sound that will play when the button will be clicked
    public AudioSource gameOverSound; //sound that will play when the game will end
    public AudioSource gameStartSound; //sound that will play when the game will start
    public TextMesh scoreText; //Display text for the player score
    public TextMesh timerText; //Display text for the time remaining
    public float gameLength; // how many seconds will the game last
    public TextMesh messageText; // display the message top the user

    private int score = 0; //the numerical data value of our score
    private float timeRemaining = 0; //Numerical time remaining for completion of the game
    private bool gameRunning = false;//Game time playing or not

	// Use this for initialization
	void Start () {
        Debug.Log("Start Method called");

	}//End of Start ()
	
	// Update is called once per frame
	void Update ()
    {
        Debug.Log("Update called");

        //Update the numerical time remaining
        timeRemaining = timeRemaining - Time.deltaTime;

        //update the visual time remaining
        timerText.text = (Mathf.CeilToInt(timeRemaining)).ToString();



        //Check if we run out of time
        if(timeRemaining <= 0)
        {
            //Only play this when we hit game over
            if (gameRunning == true)
            {
                //Play the game over sound
                gameOverSound.Play();

                //Show the player their score
                messageText.text = "Time up! Final Score =" + score.ToString();
            }//End of if (gameRunning == true)

            //Stop running the game
            gameRunning = false;

            //Stop our time from going to negative
            timeRemaining = 0;
        }//End of if(timeRemaining <= 0)

    }//End of Update ()

    void OnMouseDown()
    {
        Debug.Log("OnMouseDown method called");

        //check if the game is still running...
        if(gameRunning == true)
        {
            //Trigger our clicking sound to play
            clickSound.Play();
            // increase the score by 1
            score = score + 1;
            //update visual score
            scoreText.text = score.ToString();
        }//End of if(gameRunning == true)

        else
        {
            //game is not running and we click the button
            gameRunning = true;

            //Set timer to the full length of our game.
            timeRemaining = gameLength;

            //Player instructions
            messageText.text = "Mash the button!";

            //reset the score
            score = 0;

            //update visual score
            scoreText.text = score.ToString();

            //start game sound
            gameStartSound.Play();

        }// End of if (gameunning = true)

    }// End of OnMouseDown()


}//End of ButtonMasher class

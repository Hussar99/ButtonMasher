using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMasher : MonoBehaviour {

    //Data for our class
    public AudioSource clickSound; //sound that will play when the button will be clicked
    public TextMesh scoreText; //Display text for the player score

    private int score = 0; //the numerical data value of our score

	// Use this for initialization
	void Start () {
        Debug.Log("Start Method called");
	}//End of Start ()
	
	// Update is called once per frame
	void Update ()
    {
        Debug.Log("Update called");
    }//End of Update ()

    void OnMouseDown()
    {
        Debug.Log("OnMouseDown method called");
        //Trigger our clicking sound to play
        clickSound.Play();
        // increase the score by 1
        score = score + 1;
        //update visual score
        scoreText.text = score.ToString();
    }// End of OnMouseDown()


}//End of ButtonMasher class

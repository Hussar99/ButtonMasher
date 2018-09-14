using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMasher : MonoBehaviour {

    //Data for our class
    public AudioSource clickSound; //sound that will play when the button will be clicked

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
    }// End of OnMouseDown()


}//End of ButtonMasher class

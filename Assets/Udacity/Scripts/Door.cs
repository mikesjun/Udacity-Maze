using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
    // Create a boolean value called "opening" that can be checked in Update() 

	public static bool doorKeys;

	Animator doorAnim;
	public AudioClip doorOpen;
	public AudioClip doorClosed;

	void Start () {
		
		doorAnim = GetComponent<Animator> ();
	}

    void Update() {
        // If the door is opening and it is not fully raised
            // Animate the door raising up


    }

    public void OnDoorClicked() {
        // If the door is clicked and unlocked
            // Set the "opening" boolean to true
        // (optionally) Else
            // Play a sound to indicate the door is locked

		if (doorKeys == true) {

			doorAnim.Play ("DoorOpen");

			AudioSource audio = GetComponent<AudioSource>();
				audio.clip = doorOpen;
				audio.Play();

		} else {

			AudioSource audio = GetComponent<AudioSource>();
				audio.clip = doorClosed;
				audio.Play();
		}
	}

    public void Unlock()
    {
        // You'll need to set "locked" to false here

    }
}

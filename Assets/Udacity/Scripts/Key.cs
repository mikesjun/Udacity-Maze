using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
	public float SpinSpeed;
	public GameObject keyPoof;

	public static int keyCount;
	public Text keyCountText;

	void Start () {

		Door.doorKeys = false;
		SetCountText ();
	}

	void Update () {

		transform.Rotate (0, 0, SpinSpeed * Time.deltaTime);
	}

	public void OnKeyClicked() {
        // Instatiate the KeyPoof Prefab where this key is located
        // Make sure the poof animates vertically
        // Call the Unlock() method on the Door
        // Set the Key Collected Variable to true
        // Destroy the key. Check the Unity documentation on how to use Destroy

		keyCount = keyCount + 1;
		SetCountText ();

		if (keyCount == 2) {
					
			Door.doorKeys = true;

			keyCountText.text = "Door Unlocked";
			Destroy(GameObject.Find("Key2"));

		} else {

			SetCountText ();
			Destroy(GameObject.Find("Jar-Key1"));
		}

		Instantiate (keyPoof, transform.position, Quaternion.Euler(-90, 0, 0));	
    }

	void SetCountText() {

		keyCountText.text = "Key Count: " + keyCount.ToString () + "/2";
	}

}

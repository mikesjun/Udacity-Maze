using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour {

	public float SpinSpeed;
	public GameObject coinPoof;

	public static int coinCount;
	public Text coinCountText;

	private bool beenClicked;

	void Start () {

		beenClicked = false;
		SetCountText ();
	}

	void Update () {

		transform.Rotate(Vector3.up, SpinSpeed * Time.deltaTime);
	}

	public void OnCoinClicked() {

		coinCount = coinCount + 1;
		SetCountText ();

		Instantiate (coinPoof, transform.position, Quaternion.Euler(-90, 0, 0));
		Destroy (this.gameObject);
		//gameObject.SetActive (false);
    }

	public void OnChestClicked() {

		if (beenClicked == false) {

			if (coinCount > 3) {

				coinCount = coinCount - 3;
				SetCountText ();

			} else if (coinCount == 0) {

				SetCountText ();

			} else {
				
				coinCount = 0;
				SetCountText ();

			}

			beenClicked = true;
		}
	}

	public void OnCoinChestClicked() {

		if (beenClicked == false) {

			coinCount = coinCount + 6;
			SetCountText ();

			Instantiate (coinPoof, transform.position, Quaternion.Euler (-90, 0, 0));
			gameObject.SetActive (false);

		} else {
		
			SetCountText ();
		}

		beenClicked = true;
	}

	void SetCountText() {

		coinCountText.text = "Coin Count: " + coinCount.ToString ();
	}
}

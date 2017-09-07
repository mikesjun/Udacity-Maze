using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SignPost : MonoBehaviour
{	
	public void ResetScene() 
	{
        // Reset the scene when the user clicks the sign post

		Key.keyCount = 0;
		Coin.coinCount = 0;

		SceneManager.LoadScene( SceneManager.GetActiveScene().name );

	}
}
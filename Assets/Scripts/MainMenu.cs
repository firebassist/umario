using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	/*** Part 15 ***/

	public string startLevel;

	/*** Part 19 ***/
	public int playerLives;

	public int playerHealth;

	public void NewGame() {

		PlayerPrefs.SetInt ("CurrentPlayerScore", 0);

		PlayerPrefs.SetInt ("PlayerCurrentLives", playerLives);

		PlayerPrefs.SetInt ("PlayerCurrentHealth", playerHealth);
		PlayerPrefs.SetInt ("PlayerMaxHealth", playerHealth);

		Application.LoadLevel (startLevel);
	}

	public void QuitGame() {

//		Debug.Log ("Game Exited");
		Application.Quit ();
	}
}

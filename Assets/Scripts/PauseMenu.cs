using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {
	/*** Part 16 ***/
	public string mainMenu;

	public bool isPaused;

	public GameObject pauseMenuCanvas;

	private PlayerController player;


	void Start () {
		
		player = FindObjectOfType<PlayerController>();
	}
		
	// Update is called once per frame
	void Update () {
	
		if (isPaused) {
			pauseMenuCanvas.SetActive (true);
			Time.timeScale = 0f;
			player.enabled = false;
		} else {
			pauseMenuCanvas.SetActive (false);
			Time.timeScale = 1f;
			player.enabled = true;
		}

		if(Input.GetKeyDown (KeyCode.P)) {

			PauseUnpause();
//			isPaused = !isPaused;
		}
	}

	/*** Part 28 ***/
	public void PauseUnpause() {
		
		isPaused = !isPaused;
	}

	public void Resume() {

		isPaused = false;
	}

	public void QuitGame() {

		Application.LoadLevel (mainMenu);
	}
}

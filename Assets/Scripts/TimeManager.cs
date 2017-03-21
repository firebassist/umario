using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour {

	/*** Part 22 ***/
	//Time system above gameoverscreen in heirarchy prevents timer display in gameover
	public float startingTime;
	private float countingTime;
	private Text theText;
//	private PauseMenu pauseMenu;
//	public GameObject gameOverScreen;
	
//	public PlayerController player;

	private HealthManager healthManager;


	// Use this for initialization
	void Start () {
	
		countingTime = startingTime;
		theText = GetComponent<Text> ();
//		pauseMenu = FindObjectOfType<PauseMenu> ();
//		player = FindObjectOfType<PlayerController> ();
		healthManager = FindObjectOfType<HealthManager> ();
	}
	
	// Update is called once per frame
	void Update () {

//		if (pauseMenu.isPaused)
//			return;

		countingTime -= Time.deltaTime;

		if(countingTime <= 0)
		{
//			gameOverScreen.SetActive(true);
			//			player.gameObject.SetActive(false);
//			player.enabled = false;
			healthManager.KillPlayer();
		}

		theText.text = "" + Mathf.Round(countingTime);
	
	}

	public void ResetTime() {
		countingTime = startingTime;
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LifeManager : MonoBehaviour {

	/*** Part 18 ***/
//	public int startingLives;
	/*** Part 19 ***/
	private int lifeCounter;

	private Text theText;

	public GameObject gameOverScreen;

	public PlayerController player;

	public string mainMenu;

	public float waitAfterGameOver; //going to Main Menu

	public float displayGameOverScreenDelay; // after dying animation

//	public float waitAfterZeroLives;


	// Use this for initialization
	void Start () {
	
//		theText = getComponent<theText> ();
		theText = GetComponent<Text> ();
		/*** Part 19 ***/
		lifeCounter = PlayerPrefs.GetInt ("PlayerCurrentLives");
//		lifeCounter = startingLives;
		player = FindObjectOfType<PlayerController> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (lifeCounter <= 0) {

			ShowGameOver();
			//			gameOverScreen.SetActive(true);
			//			player.gameObject.SetActive(false);
			//			player.enabled = false;

//			waitAfterZeroLives -= Time.deltaTime;
//
//			if (waitAfterZeroLives < 0) {
//				gameOverScreen.SetActive(true);
//				player.gameObject.SetActive(false);
//			}

		}
	
		theText.text = "x " + lifeCounter;

		//optional try button press to go to Main Menu
		if (gameOverScreen.activeSelf) {
			waitAfterGameOver -= Time.deltaTime;
		}

		if (waitAfterGameOver < 0) {
			Application.LoadLevel(mainMenu);
		}

	}

	public void GiveLife() {
		lifeCounter++;
		PlayerPrefs.SetInt ("PlayerCurrentLives", lifeCounter);
	}

	public void TakeLife() {
		lifeCounter--;
		PlayerPrefs.SetInt ("PlayerCurrentLives", lifeCounter);
	}

	public void ShowGameOver()
	{
		StartCoroutine ("ShowGameOverCo");
	}

	public IEnumerator ShowGameOverCo() 
	{
		yield return new WaitForSeconds (displayGameOverScreenDelay);

		gameOverScreen.SetActive(true);
		player.gameObject.SetActive(false);
	}

}

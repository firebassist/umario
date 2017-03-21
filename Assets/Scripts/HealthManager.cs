using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour {
	/*** Part 9 ***/

	public int maxPlayerHealth;
	public static int playerHealth;
	private LevelManager levelManager;
	public bool isDead; // prevent making player dead for respawn properly

	Text text;

	/*** Part 18 ***/
	private LifeManager lifeSystem;

	/*** Part 22 ***/
//	private TimeManager timeManager;
	

	// Use this for initialization
	void Start () {
	
		text = GetComponent<Text> ();

		/*** Part 19 ***/
		playerHealth = PlayerPrefs.GetInt ("PlayerCurrentHealth");
//		playerHealth = maxPlayerHealth;
		levelManager = FindObjectOfType<LevelManager> ();
		isDead = false;
		lifeSystem = FindObjectOfType<LifeManager> ();
//		timeManager = FindObjectOfType<TimeManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (playerHealth <= 0 && !isDead) {
			playerHealth = 0; //prevents display calculation 
			levelManager.RespawnPlayer();
			lifeSystem.TakeLife();
			isDead = true;
//			timeManager.ResetTime();


		}

		text.text = "" + playerHealth;
	
	}

	public static void HurtPlayer(int damageToGive)
	{
		playerHealth -= damageToGive;
		PlayerPrefs.SetInt ("PlayerCurrentHealth", playerHealth);
	}

	public void FullHealth()
	{
		playerHealth = PlayerPrefs.GetInt ("PlayerMaxHealth");
		PlayerPrefs.SetInt ("PlayerCurrentHealth", playerHealth);
//		playerHealth = maxPlayerHealth;
	}

	public void KillPlayer()
	{
		playerHealth = 0;
	}
}

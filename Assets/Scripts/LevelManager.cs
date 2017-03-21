using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	/*** Part 3 ***/
	public GameObject currentCheckpoint;
	private PlayerController player;

//	private CameraController camera;

	public float respawnDelay;

	public int penaltyOnDeath;

	private HealthManager healthManager;/*** Part 9 ***/

	private TimeManager timeManager;

	/*** Part 5 ***/
	public GameObject deathEffect; //prefab prevents error in displaying

	// Use this for initialization
	void Start () {
	
		player = FindObjectOfType<PlayerController>();

//		camera = FindObjectOfType<CameraController>();

		healthManager = FindObjectOfType<HealthManager>();

		timeManager = FindObjectOfType<TimeManager> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void RespawnPlayer() 
	{
		StartCoroutine ("RespawnPlayerCo");
	}

	public IEnumerator RespawnPlayerCo() {
		//player dies

//		player.enabled = false;

		Instantiate (deathEffect, player.transform.position, player.transform.rotation);

		player.gameObject.SetActive(false);
		player.GetComponent<Renderer> ().enabled = false;


		


//				player.Dying ();
		timeManager.ResetTime();
//		player.GetComponent<CircleCollider2D> ().enabled = false;

		//stops camera movement when dies (camera attached to player)
//		camera.isFollowing = false;
//		player.GetComponent<Rigidbody2D> ().velocity = Vector2.zero; 

		//deduct points per death
		ScoreManager.AddPoints (-penaltyOnDeath);
		Debug.Log ("Player Respawn");

		yield return new WaitForSeconds (respawnDelay);
		//player revives

//		player.enabled = true;

		player.gameObject.SetActive(true);
		player.GetComponent<Renderer> ().enabled = true;

//				player.Living ();

		player.transform.position = currentCheckpoint.transform.position;
//		player.GetComponent<CircleCollider2D> ().enabled = true;
		/*** Part 9 ***/
		healthManager.FullHealth ();
		healthManager.isDead = false;

		timeManager.ResetTime();

//		camera.isFollowing = true;
	}
}

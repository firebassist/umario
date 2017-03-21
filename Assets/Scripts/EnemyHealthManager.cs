using UnityEngine;
using System.Collections;

public class EnemyHealthManager : MonoBehaviour {

	public int enemyHealth;

	public GameObject deathEffect;

	public int pointsOnDeath;

//	public AudioSource goombaDeathSound;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (enemyHealth <= 0) {
//			Instantiate(deathEffect, transform.position, transform.rotation);

			/*** Part 10 ***/ //works only if Goomba is grouped, sound file dragged from Goomba Main Object 
//			goombaDeathSound.Play(); 
//			GetComponent<AudioSource> ().Play();/*** Part 10 ***/
			ScoreManager.AddPoints(pointsOnDeath);
			Destroy(gameObject);

		}
	
	}

	public void giveDamage(int damageToGive) {
		enemyHealth -= damageToGive;
//		goombaDeathSound.Play();
//		GetComponent<AudioSource> ().Play();/*** Part 10 ***/
	}

}

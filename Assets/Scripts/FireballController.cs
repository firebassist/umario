using UnityEngine;
using System.Collections;

public class FireballController : MonoBehaviour {
	/*** Part 8 ***/
	public float speed;

	public PlayerController player;

	public GameObject impactEffect;

	public int pointsPerKill;

	public float rotationSpeed; /*** Part 9 ***/
	public int damageToGive;

	// Use this for initialization
	void Start () {
	
		player = FindObjectOfType<PlayerController> ();
		{
			if (player.transform.localScale.x < 0)
				speed = -speed;
			rotationSpeed = -rotationSpeed; //spin fireball /*** Part 9 ***/

		}
	}
	
	// Update is called once per frame
	void Update () {
	
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (speed, GetComponent<Rigidbody2D> ().velocity.y);

		GetComponent<Rigidbody2D> ().angularVelocity = rotationSpeed;
	}

	void OnTriggerEnter2D(Collider2D other) //capital O and capital D must be
	{
		if (other.tag == "GoombaTag") {
			//Instantiate enemy death effect animation
//			Destroy (other.gameObject);
//			ScoreManager.AddPoints (pointsPerKill);
//			other.GetComponent<AudioSource> ().Play();/*** Part 10 ***/
			other.GetComponent<EnemyHealthManager>().giveDamage(damageToGive);
		}
		/*** Part 5 ***/
		Instantiate (impactEffect, transform.position, transform.rotation);

		Destroy (gameObject);
	}
}

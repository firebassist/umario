using UnityEngine;
using System.Collections;

public class CoinPickup : MonoBehaviour {
	/*** Part 6 ***/
	public int pointsToAdd;

	public AudioSource coinSound;

	void OnTriggerEnter2D(Collider2D other) //capital O and capital D must be
	{
		if(other.GetComponent<PlayerController>() == null)
		   return;
//		if (other.name == "Player") 
		{

			ScoreManager.AddPoints (pointsToAdd);
//			GetComponent<AudioSource> ().Play();/*** Part 10 ***/
			coinSound.Play();
			Destroy (gameObject);
		}
	}

}

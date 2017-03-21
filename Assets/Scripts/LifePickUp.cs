using UnityEngine;
using System.Collections;

public class LifePickUp : MonoBehaviour {

	/*** Part 18 ***/
	private LifeManager lifeManager;

	public AudioSource extraLifeSound;
	// Use this for initialization
	void Start () {
	
		lifeManager = FindObjectOfType<LifeManager> ();
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.name == "Player")
		{
			lifeManager.GiveLife();
			extraLifeSound.Play();
			Destroy(gameObject);
		}
	}
}

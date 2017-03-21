using UnityEngine;
using System.Collections;

public class HurtPlayerOnContact : MonoBehaviour {
	/*** Part 9 ***/ //attached to Goomba and Plant removed HurtPlayer script
	public int damageToGive;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.name == "Player")
		{
			HealthManager.HurtPlayer(damageToGive);
		}
	}
}

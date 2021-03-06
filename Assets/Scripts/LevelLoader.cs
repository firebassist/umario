﻿using UnityEngine;
using System.Collections;

public class LevelLoader : MonoBehaviour {
	/*** Part 13 ***/

	private bool playerInZone;

	public string levelToLoad;
	// Use this for initialization
	void Start () {
	
		playerInZone = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(playerInZone) {

			Application.LoadLevel(levelToLoad);
		}
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.name == "Player")
		{
			playerInZone = true;
		}
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if (other.name == "Player")
		{
			playerInZone = false;
		}
	}
}

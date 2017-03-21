using UnityEngine;
using System.Collections;

public class DestroyBlockOnContact : MonoBehaviour {
	/*** Part 12 ***/
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Ground")
		{
			Destroy(other.gameObject);
		}
	}
}

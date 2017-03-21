using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	/*** Part 8 ***/
	public PlayerController player;

//	public bool isFollowing;

//	public float xOffset;
//	public float yOffset;

	private bool bounds;
	public Vector3 minCamPos;
	public Vector3 maxCamPos;

	// Use this for initialization
	void Start () {
	
		player = FindObjectOfType<PlayerController>();
		bounds = true;
//		isFollowing = false;
//		isFollowing = true;
	}
	
	// Update is called once per frame
//	void Update () {
//
////		if (isFollowing) {
////			transform.position = new Vector3 (player.transform.position.x + xOffset, player.transform.position.y + yOffset, -10f); //camera blank
////		}
//
//		if (player.transform.position.x < 6) {
//			//stops camera movement when dies (camera attached to player)
////			transform.position = new Vector3 (transform.position.x, player.transform.position.y + yOffset, -10f);
////			isFollowing = false;
//			transform.position = new Vector3 (transform.position.x, player.transform.position.y + yOffset, -10f);
////			transform.position = new Vector3 (transform.position.x,transform.position.y, -10f);
//		} 
//		if (player.transform.position.x > 6) {
//			//stops camera movement when dies (camera attached to player)
////			isFollowing = true;
//			transform.position = new Vector3 (player.transform.position.x + xOffset, player.transform.position.y + yOffset, -10f); //camera blank
////			transform.position = new Vector3 (player.transform.position.x + xOffset, transform.position.y + yOffset, -10f);
//		}
//
//	}

	void FixedUpdate() 
	{ 
		float posX = player.transform.position.x;
		float posY = player.transform.position.y;

		transform.position = new Vector3 (posX, posY, transform.position.z);

		if (bounds)  
		{
			transform.position = new Vector3 (Mathf.Clamp(transform.position.x, minCamPos.x, maxCamPos.x),
			                                  Mathf.Clamp(transform.position.y, minCamPos.y, maxCamPos.y),
			                                  Mathf.Clamp(transform.position.z, minCamPos.z, maxCamPos.z));
		}
	}
}

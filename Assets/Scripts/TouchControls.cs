using UnityEngine;
using System.Collections;

public class TouchControls : MonoBehaviour {

	/*** Part 27 ***/

	private PlayerController player;

	private PauseMenu pauseMenu;


	// Use this for initialization
	void Start () {
	
		player = FindObjectOfType<PlayerController>();

		pauseMenu = FindObjectOfType<PauseMenu>();
	}

	public void LeftArrow () {
	
		player.Move (-1);
	}

	public void RightArrow () {

		player.Move (1);
	}

	public void UnpressedArrow () {

		player.Move (0);
	}

	public void Sword () {

		player.Sword ();
	}

	public void ResetSword () {

		player.ResetSword ();
	}

	public void FireBall () {

		player.FireBall ();
	}

	public void Jump () {

		player.Jump ();
	}

	public void Pause () {
		
		pauseMenu.PauseUnpause ();
	}
}

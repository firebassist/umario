using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	/*** Part 1 ***/
	public float moveSpeed;
	public float jumpHeight;

	//prevent double jump Layer Ground is required /*** Part 2 ***/
	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	private bool grounded; 
	private bool doubleJumped;

	/*** Part 4 ***/
	private Animator anim;

	private float moveVelocity;

	public Transform firePoint;
	public GameObject fireBall;

	private bool isDead;
	public GameObject headStomper;



	/*** Part 11 ***/
//	public float knockBack;
//	public float knockBackLength;
//	public float knockBackCounter;
//	public bool knockFromRight;

	// Use this for initialization
	void Start () {
	
		anim = GetComponent<Animator> ();
		isDead = false;
	}

	void FixedUpdate() {

		grounded = Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, whatIsGround);
	}
	
	// Update is called once per frame
	void Update () {
		/*** Part 4 ***/
		if (grounded) {
			doubleJumped = false;
			anim.SetBool ("Grounded", grounded);
		}

		if (isDead) {
			anim.SetBool ("Dying", isDead);
		}

		/*** TEST FOR PC KEYBOARD LEFT AND RIGHT comment UNITY_STANDALONE || UNITY_EDITOR_WIN for mobile enable touch display on editor***/
#if UNITY_STANDALONE || UNITY_EDITOR_WIN 
//		#if UNITY_STANDALONE || UNITY_WEBPLAYER

		/*** Part 17 ***/

//		if(Input.GetKeyDown (KeyCode.J) && grounded) {
		if(Input.GetButtonDown("Jump") && grounded) {
			Jump();
//			GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);	
//			GetComponent<AudioSource> ().Play();/*** Part 10 ***/
		}

		/*** Part 17 ***/

//		moveVelocity = moveSpeed * Input.GetAxisRaw ("Horizontal");
		Move (Input.GetAxisRaw ("Horizontal"));

#endif

//		moveVelocity = 0f;
//
//		if(Input.GetKey (KeyCode.D)) {
//
//			moveVelocity = moveSpeed;
//			transform.localScale = new Vector3(1f, 1f, 1f);
//		}
		
//		if(Input.GetKey (KeyCode.A)) {
//			
//			moveVelocity = -moveSpeed;
//			transform.localScale = new Vector3(-1f, 1f, 1f); //flip other side, 0 is thin consider z /*** Part 4 ***/
//		}

		GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);

		anim.SetBool("Grounded", grounded); /*** Part 4 ***/

		anim.SetFloat("Speed", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));
	
		if (GetComponent<Rigidbody2D> ().velocity.x > 0) {
			transform.localScale = new Vector3(1f, 1f, 1f);
		}
		else if (GetComponent<Rigidbody2D> ().velocity.x < 0) {
			transform.localScale = new Vector3(-1f, 1f, 1f); //flip other side, 0 is thin consider z
		}


		/*** TEST FOR PC KEYBOARD LEFT AND RIGHT comment UNITY_STANDALONE || UNITY_EDITOR_WIN for mobile enable touch display on editor***/
#if UNITY_STANDALONE || UNITY_EDITOR_WIN
//		#if UNITY_STANDALONE || UNITY_WEBPLAYER

		/*** Part 17 ***/

//		if(Input.GetKeyDown (KeyCode.F)) {
		if(Input.GetButtonDown ("Fire1")) {
			FireBall();
//			Instantiate(fireBall, firePoint.position, firePoint.rotation);	/*** Part 8 ***/
		}

		/*** Part 12 ***/
		if (anim.GetBool ("Sword")) {
			ResetSword();
//			anim.SetBool("Sword", false);
		}
			

		/*** Part 17 ***/
//		if(Input.GetKeyDown (KeyCode.K)) {
		if(Input.GetButtonDown ("Fire2")) {
			Sword();
//			anim.SetBool("Sword", true);

		}

#endif

	}

	/*** Part 27 ***/
	public void Move(float moveInput) {
		moveVelocity = moveSpeed * moveInput;
	}

	public void Jump() {
		if(grounded) {
			GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);	
			GetComponent<AudioSource> ().Play();/*** Part 10 ***/
		}
	}



	public void FireBall() {
		Instantiate(fireBall, firePoint.position, firePoint.rotation);
	}

	public void Sword() {
		anim.SetBool("Sword", true);
	}

	public void ResetSword() {
		anim.SetBool("Sword", false);
	}

	public void Dying()
	{


//		anim.SetBool("Dying", true);
//		headStomper.SetActive(false);
//		GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);

//		GetComponent<CircleCollider2D> ().enabled = false;
//		GetComponent<Rigidbody2D> ().gravityScale = 0;
//		moveSpeed = 0;
	}

	public void Living()
	{
//		anim.SetBool("Dying", false);
//		headStomper.SetActive(true);
//		GetComponent<CircleCollider2D> ().enabled = true;
	}
}

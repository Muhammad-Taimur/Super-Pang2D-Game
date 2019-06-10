using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New_character : MonoBehaviour {
	private Rigidbody2D rigi;

	public float maxSpeed =10f;
	bool facingRight=true;
	Animator anim;

	private void awake(){

		rigi = GetComponent<Rigidbody2D> ();
	}

	void Start () {
		anim = GetComponent<Animator> ();

	}

	// Update is called once per frame
	void FixedUpdate () {
		

		float move = Input.GetAxis ("Horizontal");

		anim.SetFloat ("Speed", Mathf.Abs(move));

//		rigi.AddForce (new Vector2 (0, 700f));
		rigi.velocity = new Vector2 (move * maxSpeed, rigi.velocity.y);

		if (move > 0 && !facingRight)
			Flip ();
		else if (move < 0 && facingRight)
			Flip ();
	}
	void Flip(){
		facingRight = !facingRight;
		Vector3 theScale =transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;

	}
}

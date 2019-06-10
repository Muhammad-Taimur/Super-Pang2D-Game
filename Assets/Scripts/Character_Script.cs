using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Script : MonoBehaviour {


		private Rigidbody2D rigi;

		public float maxSpeed =1f;
		bool facingRight=true;
		Animator anim;

		private void awake(){

		 GetComponent<Rigidbody2D> ();
		}

		void Start () {
			anim = GetComponent<Animator> ();

		}

		// Update is called once per frame
		void FixedUpdate () {
//
//		if (Input.GetKeyDown("d"))
//			Debug.Log("D key was pressed.");
//		


			float move = Input.GetAxis ("Horizontal");

//		Debug.Log("Ye key was pressed.");
			anim.SetFloat ("speed", Mathf.Abs(move));
//		Debug.Log("Chal key was pressed.");

			//		rigi.AddForce (new Vector2 (0, 700f));
		GetComponent<Rigidbody2D>().velocity = new Vector2 (move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);

			if (move > 0 && !facingRight)
				Flip ();
			else if (move < 0 && facingRight)
				Flip ();
		}
		void Flip(){
			facingRight = !facingRight;
			Vector3 theScale =transform.localScale;
			theScale.x *= 	-1;
		transform.localScale = theScale;

//		Vector3 the =transform.localPosition;
//		the.x *= 	-1;

//		transform.localPosition.x *= -1;

		}
	}

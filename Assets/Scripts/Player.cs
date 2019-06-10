 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Player : MonoBehaviour {

//	public bool Idle;
//	public Animator chAnim;

//	public bool right_walk;
	public float speed = 4f;

	public Rigidbody2D rb;

	private float movement = 0f;

//	bool gameHasEnded = false;

	void Update () {

		movement = Input.GetAxisRaw ("Horizontal") * speed;
//
//		if (Input.GetKeyDown (KeyCode.D) == true) {
//			movement = Input.GetAxisRaw ("right_walk") * speed;
////					movement = Input.GetAxisRaw ("Horizontal") * speed;
//
//		} else {
//		
//			movement = Input.GetAxisRaw ("Idle");
//		
//		}

	}

//	void Update()
//	{
//		
//		if (Input.GetButtonDown (KeyCode.D)== true) {
//			movement = Input.GetAxis ("Idle" * speed);
//		}
//	
//	}	
	void FixedUpdate (){
	
		rb.MovePosition (rb.position + new Vector2(movement * Time.fixedDeltaTime, 0f));
	}

	void OnCollisionEnter2D (Collision2D col){

		if (col.collider.tag == "Ball") {
		
			Debug.Log ("Game Over!");

//			SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex+1);
			Application.LoadLevel("You_Lose"); //You get the idea, but be sure to put your winner scene in the build settings.

		}
	


	}


//	public void EndGame(){
//	
//		if (gameHasEnded == false) {
//		
//			gameHasEnded = true;
//			Debug.Log ("Game Over");
//		}
//	}

}




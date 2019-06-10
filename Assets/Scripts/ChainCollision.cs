
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChainCollision : MonoBehaviour {

	public int counter = 0;
	void OnTriggerEnter2D (Collider2D col){
		 
		Chain.IsFired = false;

		if (col.tag == "Ball") {	
			col.GetComponent<Ball>().Split();
			counter++;
			Debug.Log (counter);
		} 

		if (counter == 31) {
		
			Debug.Log("Level2");
			Application.LoadLevel ("Level2");
//			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
		}
	}



}

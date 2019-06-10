
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChainCollisionLevel2 : MonoBehaviour {

	public int counter = 0;
	void OnTriggerEnter2D (Collider2D col){

		Chain.IsFired = false;

		if (col.tag == "Ball") {	
			col.GetComponent<Ball>().Split();
			counter++;
			Debug.Log (counter);
		} 

		if (counter == 30) {
//			Debug.Log(counter);
			Debug.Log("You Win");
			Application.LoadLevel ("You_Win");
//			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
		}
	}



}

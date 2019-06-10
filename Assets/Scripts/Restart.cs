using UnityEngine.SceneManagement;using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour {

	void OnGUI(){
	
		const int buttonWidth = 80;
		const int buttonHeight = 80;

		if (
			GUI.Button (
				new Rect (
					Screen.width / 2 - (buttonWidth / 2),
					(2 * Screen.height / 3) - (buttonHeight / 2),
					buttonWidth,
					buttonHeight
				),
				"Restart!"
			)) 
		
		
		{

			Application.LoadLevel("Finish");
//			SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex+1);

		}
		}





}

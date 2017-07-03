using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//Types the text slowly
//Received help from http://answers.unity3d.com/questions/50104/how-to-make-text-that-is-writen-automatically-lett.html
public class SlowText1 : MonoBehaviour {

	private float letterSpeed = 0.1f;
	private float spaceSpeed = 0.2f;

//	public AudioSource[] beepType;

	public CanvasGroup canvasGroup;

	private float random;
	private int randomInt;

	string words; 
	Text wordsToScreen;

	void Start () {
		
		wordsToScreen = GetComponent<Text> ();
		words = wordsToScreen.text;
		wordsToScreen.text = "";
		StartCoroutine (typeText ());

	}

	IEnumerator typeText() {
		foreach (char letter in words.ToCharArray()) {
			wordsToScreen.text += letter;

		/*	if (beepType != null) {

				random = Random.Range (0, beepType.Length);
				randomInt = (int) random; 	
				(beepType [randomInt]).Play ();
				yield return 0;

			}*/

			if (string.IsNullOrEmpty(letter.ToString()))
				yield return new WaitForSeconds (spaceSpeed);
			else 
				yield return new WaitForSeconds (letterSpeed);
		}
			
		canvasGroup.GetComponent<FadeOut1> ().fadeMe ();


	}
	

}

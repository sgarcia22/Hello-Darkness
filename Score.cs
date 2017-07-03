using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour {

	private int score = 0;
	private string scoreString;
	public Text scoreText;

	void Update () {
		if (score == 3) {
			SceneManager.LoadScene (4);
		}
	}

	public void increaseScore() {
		score++;
		scoreString = score.ToString ();
		scoreText.text = scoreString;

	}
}

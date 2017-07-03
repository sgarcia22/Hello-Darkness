using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeOut1 : MonoBehaviour {




	/// <summary>
	/// Received help from youtube.com/watch?v=MkolZTFUego
	/// </summary>
	public void fadeMe() {
		StartCoroutine (doFade ());

	}

	void Update() {
		if (Input.GetKey (KeyCode.E)) {
			SceneManager.LoadScene (0);
		}
	}

	IEnumerator doFade() {

		CanvasGroup canvasGroup = GetComponent<CanvasGroup> ();
		while (canvasGroup.alpha > 0) {
			canvasGroup.alpha -= Time.deltaTime / 2;
			yield return null;
		}

		canvasGroup.interactable = false;
		yield return null;

		if (canvasGroup.alpha == 0 &&  (SceneManager.GetActiveScene ().buildIndex == 4))
			SceneManager.LoadScene (0);

	}

}

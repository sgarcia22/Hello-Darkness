using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeOut : MonoBehaviour {


	/// <summary>
	/// Received help from youtube.com/watch?v=MkolZTFUego
	/// </summary>
	public void fadeMe() {
		StartCoroutine (doFade ());

	}

	IEnumerator doFade() {

		CanvasGroup canvasGroup = GetComponent<CanvasGroup> ();
		while (canvasGroup.alpha > 0) {
			canvasGroup.alpha -= Time.deltaTime / 2;
			yield return null;
		}

		canvasGroup.interactable = false;
		yield return null;

		if (canvasGroup.alpha == 0 &&  (SceneManager.GetActiveScene ().buildIndex == 2))
			SceneManager.LoadScene (1);

	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public float nextLevelTimer = 15.0f;

	// Use this for initialization
	void Start () {
        // SceneManager.LoadScene(0);
	}

	// Update is called once per frame
	void Update () {
		if (nextLevelTimer > 0) {
			nextLevelTimer -= Time.deltaTime;
			if (nextLevelTimer < 0) {
				LoadNextScene();
			}
		}
	}

	public void LoadNextScene () {
		int currentIndex = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene(currentIndex + 1);
	}

	public void LoadPreviousScene () {
		int currentIndex = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene(currentIndex - 1);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {

	Text score;
	ScoreKeeper scoreKeeper;

	// Use this for initialization
	void Start () {
		score = GetComponent<Text>();
		scoreKeeper = FindObjectOfType<ScoreKeeper>();
	}
	
	// Update is called once per frame
	void Update () {
		score.text = "Score: " + scoreKeeper.score;
	}
}

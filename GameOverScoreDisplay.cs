using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScoreDisplay : MonoBehaviour {

	Text score;
	ScoreAbsorb scoreAbsorb;

	// Use this for initialization
	void Start () {
		score = GetComponent<Text>();
		scoreAbsorb = FindObjectOfType<ScoreAbsorb>();
	}
	
	// Update is called once per frame
	void Update () {
		print("The score abosrbed is: " +scoreAbsorb.score);
		score.text = "Score: " + scoreAbsorb.score;
	}
}

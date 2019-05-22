using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAbsorb : MonoBehaviour {

	public int score;

	// Use this for initialization
	void Start () {
		ScoreKeeper old = FindObjectOfType<ScoreKeeper>();
		score = 1;
		if (old) {
			print("inside old");
			score = old.score;
			Destroy(old.gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

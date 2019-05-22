using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectScoring : MonoBehaviour {

	public int scorePerHit = 1;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	//detect collisions
	void OnCollisionEnter(Collision collision){
		ScoreKeeper scoreKeeper = FindObjectOfType<ScoreKeeper>();
		scoreKeeper.IncrementScore(scorePerHit);
	}
}

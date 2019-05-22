using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondaryTrigger : MonoBehaviour {

	Collider expected_collider;
	int scoreIncrease;

	public void ExpectCollider(Collider collider, int si){
		expected_collider = collider;
		scoreIncrease = si;
	}

	void OnTriggerEnter(Collider other_collider) {
		print("secondary trigger hit");
		if(other_collider == expected_collider) {
			ScoreKeeper score_keeper = FindObjectOfType<ScoreKeeper>();
			score_keeper.IncrementScore(scoreIncrease);
		}
	}
}

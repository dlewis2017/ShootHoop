using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeRemainingDisplay : MonoBehaviour {

	Text timeLeft;
	LevelManager levelManager;

	// Use this for initialization
	void Start () {
		timeLeft = GetComponent<Text>();
		levelManager = FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
		timeLeft.text = "Time Remaining: " + levelManager.nextLevelTimer;
	}
}

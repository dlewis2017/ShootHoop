using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour {

	public GameObject ballPrefab;
	public float ballSpeed = 6.0f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		//Pick up mouse press and launch ball forward in camera direction
		if(Input.GetButtonDown("Fire1")){
			GameObject instance = Instantiate(ballPrefab);
			Rigidbody rb = instance.GetComponent<Rigidbody>();
			Camera camera = GetComponentInChildren<Camera>();

			instance.transform.position = transform.position;
			//launch ball in direction of global camera with slight arc
			rb.velocity = camera.transform.rotation * new Vector3(0,0,1) * ballSpeed;

		}
	}
}

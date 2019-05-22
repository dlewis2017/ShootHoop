﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
	

	}

	// Update is called once per frame
	void Update () {
		float rotationSpeed = 5.0f;
		float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
		float mouseY = Input.GetAxis("Mouse Y") * -1 * rotationSpeed;
		Camera camera = GetComponentInChildren<Camera>();

		//rotate body (scene/parent)
		transform.localRotation = Quaternion.Euler(0, mouseX, 0) * transform.localRotation;
		//rotate head (child)
		camera.transform.localRotation = Quaternion.Euler(mouseY,0,0) * camera.transform.localRotation;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimaryTrigger : MonoBehaviour {

	void OnTriggerEnter(Collider collider) {
		int increment = 0;
		print("first trigger hit");
		switch (transform.parent.name) {
			case "RingBoard":
				increment = 1;
				break;
			case "RingBoard2":
				increment = 2;
				break;
			case "RingBoard3":
				increment = 3;
				break;
		}
		SecondaryTrigger trigger = GetComponentInChildren<SecondaryTrigger>();
		trigger.ExpectCollider(collider,increment);
	}
}

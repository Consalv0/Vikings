using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Vector3 bodyPos = Camera.main.WorldToScreenPoint(transform.position);
		Vector3 dir = Input.mousePosition - bodyPos;
		float newAngle = (Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg) + 270;
		Quaternion newRotation = Quaternion.AngleAxis(newAngle, Vector3.forward);
		transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, 0.05f);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerMovement : MonoBehaviour {
	public float DeltaSpeed;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void LateUpdate () {
		var x = Input.GetAxis("Horizontal") * Time.deltaTime * DeltaSpeed;
    var z = Input.GetAxis("Vertical") * Time.deltaTime * DeltaSpeed;

    transform.Translate(x, 0, 0);
    transform.Translate(0, z, 0);
	}
}

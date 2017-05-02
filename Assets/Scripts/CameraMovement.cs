using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {
    private GameObject player;
    private Vector3 offset;
    private Vector3 velocity = Vector3.zero;

  void Start () {
    player = GameObject.FindWithTag("Player");
	}

	void LateUpdate () {
    transform.position = Vector3.SmoothDamp(transform.position, player.transform.position, ref velocity, 0.2f);
	}
}

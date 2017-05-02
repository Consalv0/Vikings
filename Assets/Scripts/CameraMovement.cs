using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    Transform target;

    void Start ()
    {
        target = GameObject.Find("Player").transform;
	}

	void Update ()
    {
        
	}

    private void FixedUpdate()
    {
        transform.position = target.position + new Vector3(0, 0, -10);
    }

}

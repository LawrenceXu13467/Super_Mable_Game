using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public Transform ball; // Transform is position info
	private Vector3 offset; // 3d vector named offset

	// Use this for initialization
	void Start () {
		offset = this.transform.position - ball.position; // a vector pointing from the ball to the camera
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = ball.position + offset;

	}
}

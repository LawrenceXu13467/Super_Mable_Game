using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportZone : MonoBehaviour {

	public Transform spawnpoint;

	void OnTriggerEnter(Collider other){
		other.transform.position = spawnpoint.position;
		Rigidbody rb = other.GetComponent<Rigidbody>();
		rb.Sleep();

	}


	// Not gonna use the code below
//	// Use this for initialization
//	void Start () {
//		
//	}
//	
//	// Update is called once per frame
//	void Update () {
//		
//	}
}

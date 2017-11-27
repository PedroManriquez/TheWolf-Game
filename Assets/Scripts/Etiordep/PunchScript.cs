using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.J)) {
			GetComponent<Animator> ().SetBool ("isPunch", true);
		}
		if (Input.GetKeyUp(KeyCode.J)) {
			GetComponent<Animator> ().SetBool ("isPunch", false);
		}
	}
}
